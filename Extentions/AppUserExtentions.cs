using System;
using DatingApp.DTOs;
using DatingApp.Entities;
using DatingApp.Interfaces;

namespace DatingApp.Extentions;

public static class AppUserExtentions
{
    public static UserDto ToDto(this AppUser user, ITokenService tokenService)
    {
        return new UserDto
        {
            Id = user.Id,
            DisplayName = user.DisplayName,
            Email = user.Email,
            Token = tokenService.CreateToken(user)
        };
    }
}