using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RugbyManagementAPI.Models
{
    public class Player
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
    }
}
