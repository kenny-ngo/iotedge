﻿// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.Azure.Devices.Edge.Agent.Core
{
    using System.Threading;
    using System.Threading.Tasks;

    public interface ICommand
    {
        Task ExecuteAsync(CancellationToken token);

        Task UndoAsync(CancellationToken token);
    }
}