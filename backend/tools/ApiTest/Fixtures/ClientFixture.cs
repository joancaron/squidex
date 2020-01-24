﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using ApiTest.Model;
using Squidex.ClientLibrary;
using Squidex.ClientLibrary.Management;

namespace ApiTest.Fixtures
{
    public class ClientFixture : IDisposable
    {
        public SquidexClientManager ClientManager { get; }

        public IAppsClient Apps { get; }

        public ClientFixture()
        {
            ClientManager = TestClient.ClientManager;

            Apps = ClientManager.CreateAppsClient();
        }

        public virtual void Dispose()
        {
        }
    }
}
