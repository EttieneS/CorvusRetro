using System.Text.RegularExpressions;

namespace RugbyManagementAPI.ViewModels
{
    public class MatchViewModel
    {
        public long Id { get; set; }
        public string? TeamA {  get; set; }
        public string? TeamB { get; set; }
        public string? Score { get; set; }
        public string? Winner { get; set; }
    }
}
