using System.ComponentModel.DataAnnotations;

namespace WebPlusLogicWithAPIApps.Models
{
    public class OrderViewModels
    {
            [Display(Name = "Rose")]
            public string FlowerName { get; set; }
            [Required]
            [Display(Name = "Recipient Name")]
            public string RecipientName { get; set; }

            [Display(Name = "Street")]
            public string DeliveryStreet { get; set; }

            [Display(Name = "City")]
            public string DeliveryCity { get; set; }

            [Display(Name = "State")]
            public string DeliveryState { get; set; }

            [Display(Name = "Postal Code")]
            public string DeliveryPostalCode { get; set; }

            [Required]
            [Display(Name = "Phone")]
            public string Phone { get; set; }

    }
}