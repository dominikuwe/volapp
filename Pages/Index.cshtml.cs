using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    [BindProperty] public double A { get; set; }
    [BindProperty] public double B { get; set; }
    [BindProperty] public double H { get; set; }
    [BindProperty] public double TiltFactor { get; set; }

    public double Result { get; set; }
    public bool HasResult { get; set; }

    public void OnPost()
    {
        double baseVolume = (2.0 / 3.0) * Math.PI * A * B * H;

        Result = baseVolume * TiltFactor;

        HasResult = true;
    }
}