﻿using System;
using System.Globalization;

namespace CloudFoundry.CloudController.Common.ServiceLocation
{
    /// <inheritdoc/>
    internal abstract class ServiceLocationManager : IServiceLocationManager
    {
        /// <inheritdoc/>
        public void RegisterServiceInstance<TService>(TService instance)
        {
            this.RegisterServiceInstance(typeof(TService),
                                  instance);
        }

        /// <inheritdoc/>
        public abstract void RegisterServiceInstance(Type type, object instance);

        /// <inheritdoc/>
        public void RegisterServiceType<TInterface, TConcrete>() where TConcrete : class, TInterface
        {
            this.RegisterServiceType(typeof(TInterface), typeof(TConcrete));
        }

        /// <inheritdoc/>
        public void RegisterServiceType(Type type, Type registrationValue)
        {
            ThrowIfInvalidRegistration(type, registrationValue);

            var obj = Activator.CreateInstance(registrationValue);

            this.RegisterServiceInstance(type, obj);
        }

        /// <summary>
        /// Throws an exception if the type or implementation are null.
        /// </summary>
        /// <param name="type">A Type object.</param>
        /// <param name="implementation">The implementation of the given Type.</param>
        internal static void ThrowIfNullInstance(Type type, object implementation)
        {
            if (ReferenceEquals(type, null))
            {
                var msg = string.Format(CultureInfo.InvariantCulture,
                                           "Cannot register a null service.");
                throw new InvalidOperationException(msg);
            }

            if (ReferenceEquals(implementation, null))
            {
                var msg = string.Format(
                    CultureInfo.InvariantCulture,
                    "A service cannot have a null implementation '{0}'",
                    type.FullName);
                throw new InvalidOperationException(msg);
            }
        }

        /// <summary>
        /// Throws an exception if the given Type and implementation represent an invalid registration.
        /// An invalid registration is one where the given Type is of a restricted type, is not an interface, or the given implementation does not inherit from the given Type.
        /// </summary>
        /// <param name="type">A Type object.</param>
        /// <param name="implementation">The implementation of the given Type.</param>
        internal static void ThrowIfInvalidRegistration(Type type, Type implementation)
        {
            ThrowIfNullInstance(type,
                                implementation);
            if (type == typeof(IServiceLocationRuntimeManager) ||
                type == typeof(IServiceLocationOverrideManager) ||
                type == typeof(IServiceLocationManager) ||
                type == typeof(IServiceLocator))
            {
                var msg = string.Format(
                    CultureInfo.InvariantCulture,
                    "Service location services cannot be registered or overridden: '{0}'",
                    type.FullName);
                throw new InvalidOperationException(msg);
            }

            if (!type.IsInterface())
            {
                var msg = string.Format(
                    CultureInfo.InvariantCulture,
                    "The following type: '{0}' is not an interface",
                    type.FullName);
                throw new InvalidOperationException(msg);
            }

            if (!type.IsAssignableFrom(implementation))
            {
                var msg = string.Format(
                    CultureInfo.InvariantCulture,
                    "Cannot register or override the service '{0}' for the type '{1}' which is not derived from the service",
                    implementation.FullName,
                    type.FullName);
                throw new InvalidOperationException(msg);
            }
        }
    }
}