/*
 Copyright (c) 2024 HigginsSoft
 Written by Alexander Higgins https://github.com/alexhiggins732/ 
 

 Copyright (c) 2018, Brock Allen & Dominick Baier. All rights reserved.

 Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information. 
 Source code for this software can be found at https://github.com/alexhiggins732/IdentityServer8

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.

*/

using System.Threading.Tasks;
using IdentityServer8.Models;

namespace IdentityServer8.Services
{
    /// <summary>
    /// The device flow throttling service.
    /// </summary>
    public interface IDeviceFlowThrottlingService
    {
        /// <summary>
        /// Decides if the requesting client and device code needs to slow down.
        /// </summary>
        /// <param name="deviceCode">The device code.</param>
        /// <param name="details">The device code details.</param>
        /// <returns></returns>
        Task<bool> ShouldSlowDown(string deviceCode, DeviceCode details);
    }
}