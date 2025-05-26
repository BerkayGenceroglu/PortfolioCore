using System.ComponentModel.DataAnnotations;

namespace PortfolioCore.Entities
{
    public class Service
    {
        [Key]
        public int servicesID { get; set; }
        public string serviceTitle { get; set; }
        public string serviceIcon { get; set; }
        public string serviceDescription { get; set; }
    }
}
