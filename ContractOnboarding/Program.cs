using ContractOnboarding.Components;
using ContractOnboarding.Services; // Habilitar el uso de ContractService

var builder = WebApplication.CreateBuilder(args);

// (Motor base
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// inject ContractService 
builder.Services.AddScoped<ContractService>();

var app = builder.Build();

// Configuración del servidor web (Pipeline HTTP)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();