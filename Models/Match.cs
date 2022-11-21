using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RugbyManagementAPI.Models
{
    public class Match
    {
        public long Id { get; set; }        
        public long TeamAId { get; set; }                       
        public long TeamBId { get; set; }                
    }
}
