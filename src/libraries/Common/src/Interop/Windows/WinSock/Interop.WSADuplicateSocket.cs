// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Net.Sockets;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Winsock
    {
        [DllImport(Interop.Libraries.Ws2_32, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern unsafe int WSADuplicateSocket(
            [In] SafeSocketHandle s,
            [In] uint dwProcessId,
            [In] WSAPROTOCOL_INFOW* lpProtocolInfo
        );
    }
}
