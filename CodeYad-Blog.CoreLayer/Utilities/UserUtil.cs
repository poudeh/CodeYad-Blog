﻿using System;
using System.Security.Claims;

namespace CodeYad_Blog.CoreLayer.Utilities
{
    public static class UserUtil
    {
        public static int GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentNullException(nameof(principal));
            }

            return Convert.ToInt32(principal.FindFirst(ClaimTypes.NameIdentifier)?.Value);

        }
    }
}