﻿// -----------------------------------------------------------------------
// <copyright file="ServiceCostsBillingPeriod.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.Models.ServiceCosts
{
    using Models.JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents service costs billing periods.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum ServiceCostsBillingPeriod
    {
        /// <summary>
        /// Default billing period, does not mean anything.
        /// </summary>
        None,

        /// <summary>
        /// The most recently completed billing period.
        /// </summary>
        MostRecent,

        /// <summary>
        /// The current billing period that is ongoing.
        /// </summary>
        Current
    }
}