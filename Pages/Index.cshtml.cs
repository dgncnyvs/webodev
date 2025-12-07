using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebSite.Pages;

public class IndexModel : PageModel
{
    // Modelde tanımladığımız ve HTML'de kullanacağımız bir özellik (property)
    [BindProperty]
    public string Mesaj { get; set; } = "Merhaba Dünya!";

    // Sayfa ilk yüklendiğinde (HTTP GET isteği) çalışan metot
    public void OnGet()
    {
        // Burada veritabanı sorgusu, API çağrısı gibi işlemler yapılabilir.
        Mesaj = "Sayfa başarıyla yüklendi!";
    }

    // Bir form gönderildiğinde (HTTP POST isteği) çalışacak metot örneği
    public IActionResult OnPost()
    {
        // Formdan gelen verileri işleme
        Mesaj = "Form gönderildi ve işlendi!";
        return Page(); // Mevcut sayfayı yeniden yükle
    }
}
