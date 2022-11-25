﻿using Blazor.Learner.Shared.Models;
using System.Threading.Tasks;

namespace Blazor.Learner.Client.Services
{
    public interface IAuthService
    {
        Task Login(LoginRequest loginRequest);
        Task Register(RegisterRequest registerRequest);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
    }
}
