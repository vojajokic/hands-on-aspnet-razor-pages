using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BigStar.Models;

namespace BigStar.Pages.Forms
{
    [BindProperties]
  public class PriceYourCardsModel : PageModel
  {
    public TradeCard Card { get; set; }
    public string Message { get; set; } = "No card found!";
    public void OnGet()
    {

    }
    public void OnPost()
    {
      var offerPrice = Card.CardCount * 12.50;
      Message = $"Our offer for {Card.CardCount} {Card.CardName} card(s) in {Card.Condition} condition = {offerPrice:C}USD";
    }
  }
}
