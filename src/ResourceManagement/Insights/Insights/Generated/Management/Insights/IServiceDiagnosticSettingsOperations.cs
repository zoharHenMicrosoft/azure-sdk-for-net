// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights
{
    /// <summary>
    /// Operations for managing service diagnostic settings.
    /// </summary>
    public partial interface IServiceDiagnosticSettingsOperations
    {
        /// <summary>
        /// Deletes the diagnostic settings for the specified resource.
        /// </summary>
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Generic empty response. We only pass it to ensure json error
        /// handling
        /// </returns>
        Task<EmptyResponse> DeleteAsync(string resourceUri, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the active diagnostic settings. To get the diagnostic settings
        /// being applied, use GetStatus.
        /// </summary>
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<ServiceDiagnosticSettingsGetResponse> GetAsync(string resourceUri, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create or update new diagnostic settings for the specified
        /// resource. This operation is long running. Use GetStatus to check
        /// the status of this operation.
        /// </summary>
        /// <param name='resourceUri'>
        /// The resource identifier of the configuration.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Generic empty response. We only pass it to ensure json error
        /// handling
        /// </returns>
        Task<EmptyResponse> PutAsync(string resourceUri, ServiceDiagnosticSettingsPutParameters parameters, CancellationToken cancellationToken);
    }
}
