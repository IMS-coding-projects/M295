﻿namespace M295.Models;

public class UpdateUserRequest
{
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
}