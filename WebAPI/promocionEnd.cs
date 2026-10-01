using Maza.Application.Services;
using Maza.DTOs;
using Maza.DomainModel;

namespace WebAPI
{
    public static class PromocionEndpoints
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
                Promocion promoDto = await promocionService.CrearPromoConDTOAsync(dto);
            });

            app.MapGet("/promocion/{id}", async (IPromocionService promocionService, int id) =>
            {
                var promo = await promocionService.ExpirarPromoAsync(id);
                if (promo)
                {
                    return Results.Ok("Promoción expirada correctamente.");
                }
                else
                {
                    return Results.NotFound("Promoción no encontrada.");
                }
            });
        }
    }
}
