﻿// -----------------------------------------------------------------------
// <copyright file="OrderLinks.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.Models.Orders
{
    /// <summary>
    /// Bundles the links for an order.
    /// </summary>
    public sealed class OrderLinks : StandardResourceLinks
    {
        /// <summary>
        /// Gets or sets the link to the patch operation. 
        /// </summary>
        public Link PatchOperation { get; set; }

        /// <summary>
        /// Gets or sets the link to the provisioning status of an order.
        /// </summary>
        public Link ProvisioningStatus { get; set; }
    }
}