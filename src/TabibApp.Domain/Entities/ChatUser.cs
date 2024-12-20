﻿using TabibApp.Application.Dtos;

public class ChatUser
{
    public int ChatId { get; set; }
    public Chat Chat { get; set; }

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public UserRole Role { get; set; }
}
