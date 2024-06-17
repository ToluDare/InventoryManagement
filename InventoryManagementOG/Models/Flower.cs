using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace InventoryManagementOG.Models
{
    public class Flower
    {
        public string name { get; set; }
        public string type { get; set; }
        public List<Material> materials_used { get; set; }

        public double cost_price{ get; set; }

        public string img { get; set; }

       //constructor


    }
}
