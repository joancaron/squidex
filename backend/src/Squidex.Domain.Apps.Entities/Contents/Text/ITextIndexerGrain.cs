// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orleans;
using Orleans.Concurrency;

namespace Squidex.Domain.Apps.Entities.Contents.Text
{
    public interface ITextIndexerGrain : IGrainWithGuidKey
    {
        Task IndexAsync(Immutable<IIndexCommand[]> updates);

        Task<List<Guid>> SearchAsync(string queryText, SearchContext context);
    }
}