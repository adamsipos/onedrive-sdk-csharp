// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System.Collections.Generic;
    using Microsoft.Graph;

    /// <summary>
    /// The interface IItemContentRequestBuilder.
    /// </summary>
    public partial interface IItemContentRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IItemContentRequest Request();

        IItemContentRequest Request(string conflict);
    }
}
