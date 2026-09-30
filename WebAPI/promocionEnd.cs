using Maza.Application.Services;
namespace WebAPI
{
    public static class promocionEndpoints
    {
        public static void MapPromocionEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/promocion/{estado}", async(PromocionService promocionService, string estado) =>
            {
                // Lógica para obtener la promoción
                var promociones = await promocionService.PromosXestadoAsync(estado);

                return Results.Ok(promociones);
            })
            .WithName("GetPromocion")
            .WithTags("Promocion");
        }
    }
}
