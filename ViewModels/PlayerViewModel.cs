﻿namespace RugbyManagementAPI.ViewModels
{
    public class PlayerViewModel
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? Active { get; set; }
        public string? TeamName { get; set; }
    }
}
