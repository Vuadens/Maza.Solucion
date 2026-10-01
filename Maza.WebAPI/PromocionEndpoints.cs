using Maza.Application.Services;
using Maza.DomainModel;
using Maza.DTOs;

namespace Maza.WebAPI;

public static class PromocionEndpoints
{
    public static void MapPromocionEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/promocion/estado/{estado}", async (IPromocionService promocionService, string estado) =>
        {
            var promociones = await promocionService.PromosXestadoAsync(estado);
            return Results.Ok(promociones);
        })
        .WithName("GetPromocionesPorEstado")
        .WithTags("Promocion");

        app.MapPost("/promocion", async (PromoDTO dto, IPromocionService promocionService) =>
        {
            Promocion promocion = await promocionService.CrearPromoConDTOAsync(dto);
            return Results.Created($"/promocion/{promocion.PromocionId}", promocion);
        })
        .WithName("CrearPromocion")
        .WithTags("Promocion");

        app.MapPost("/promocion/{id:int}/expirar", async (IPromocionService promocionService, int id) =>
        {
            var expirada = await promocionService.ExpirarPromoAsync(id);
            return expirada
                ? Results.Ok("Promoción expirada correctamente.")
                : Results.NotFound("Promoción no encontrada.");
        })
        .WithName("ExpirarPromocion")
        .WithTags("Promocion");
    }
}
