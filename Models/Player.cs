using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RugbyManagementAPI.Models
{
    public class Player
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long Position { get; set; }
        public Boolean Active { get; set; }
        public long TeamId { get; set; }
    }
}
