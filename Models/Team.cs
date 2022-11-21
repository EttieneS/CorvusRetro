using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RugbyManagementAPI.Models
{
    public class Team
    {
        public long Id { get; set; }
        public string? TeamName { get; set; }
    }
}
