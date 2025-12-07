using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// 1. Web Uygulaması Oluşturma
var builder = WebApplication.CreateBuilder(args);

// 2. Servisleri Ekleme (Razor Pages desteğini ekliyoruz)
builder.Services.AddRazorPages();

// 3. Uygulamayı İnşa Etme
var app = builder.Build();

// 4. İstek İşlem Hattını (Pipeline) Yapılandırma
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // Https zorlaması (üretim ortamı için)
    app.UseHsts(); 
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // wwwroot klasöründeki statik dosyaları kullanmayı sağlar
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages(); // Razor Pages için uç nokta eşleştirmesini yapar

// 5. Uygulamayı Çalıştırma
app.Run();
