//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.BindingServiceInstanceToRoute()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/241/service_instances/binding_a_service_instance_to_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class BindingServiceInstanceToRouteRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractBindingServiceInstanceToRouteRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServiceInstancesEndpoint.BindingServiceInstanceToRoute()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/241/service_instances/binding_a_service_instance_to_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractBindingServiceInstanceToRouteRequest
    {

        /// <summary> 
        /// <para>Arbitrary parameters to pass along to the service broker. Must be a JSON object.</para>
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Parameters
        {
            get;
            set;
        }
    }
}