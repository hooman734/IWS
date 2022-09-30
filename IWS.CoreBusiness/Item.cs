using System.ComponentModel.DataAnnotations;

namespace IWS.CoreBusiness;

public class Item
{
    public Guid ItemId { get; init; }
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    public string Description { get; set; } = string.Empty;
    
    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "It should be a positive number!")]
    public int Quantity { get; set; }
    
    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "It should be a positive number!")]
    public decimal Price { get; set; }

    public string FormattedPrice()
    {
        return Price.ToString("c");
    }
}