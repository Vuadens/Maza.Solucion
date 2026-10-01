using Maza.Application.Services;
using Maza.DTOs;

namespace WebAPI
{
    public static class promocionEndpoints
    {
        public static void MapPromocionEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/promocion/{estado}", async(IPromocionService promocionService, string estado) =>
            {
                // Lógica para obtener la promoción
                var promociones = await promocionService.PromosXestadoAsync(estado);

                return Results.Ok(promociones);
            })
            .WithName("GetPromocion")
            .WithTags("Promocion");

            app.MapPost("/promocion", async (PromoDTO dto, IPromocionService promocionService) =>
            {
                PromoDTO promoDto = await promocionService.CrearPromoConDTOAsync(dto);
            });
        }
    }
}
