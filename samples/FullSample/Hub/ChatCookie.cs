﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Microsoft.Azure.SignalR.Samples.ChatRoom
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    [Authorize(Roles = "Admin")]
    [Authorize(Policy = "ClaimBasedAuth")]
    [Authorize(Policy = "PolicyBasedAuth")]
    public class ChatCookie : ChatBase
    {
    }
}
