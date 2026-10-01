using Maza.Data;
using Maza.DomainModel;
using Maza.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Maza.Application.Services
{
    public class PromocionService : IPromocionService // logica real del service, a partir de la firma
    {
        private readonly IPromocionRepository _PromocionRepository;
    
        public PromocionService(IPromocionRepository promocionRepository) //inyeccion de dependencia del repositorio en el service para que pueda ser usado en los metodos de la clase que estamos definiendo
        {
            _PromocionRepository = promocionRepository;
        } //cual es la logica atras de esto? como lo aprendo para replicar esta inyeccion de dependencias x mi cuenta?
    
        public async Task<Promocion> CrearPromoConDTOAsync(PromoDTO promoDTO) //validaciones del service sobre los datos que ingreso el usuario,
        {                                                                //los cuales viajaron en un DTO, ya que el mismo no debe poder modificar 
            if (string.IsNullOrWhiteSpace(promoDTO.Nombre))              // ni la ID ni el estado de la promoción, que son datos que se generan en el backend. 
            {
                throw new ArgumentException("El nombre de la promoción no puede estar vacío.");
            }

            if (promoDTO.FechaInicio >= promoDTO.FechaFin) {

                throw new ArgumentException("La fecha de inicio no puede ser mayor o igual a la fecha de fin.");
            }

            if (promoDTO.Descuento > 100 || promoDTO.Descuento < 1) 
            {
                throw new ArgumentException("El descuento debe estar entre 1 y 100.");
            }
            
            return await _PromocionRepository.CrearPromoConDTOAsync(promoDTO);
        }
        
        public async Task<List<Promocion>>PromosXestadoAsync(string estado)
        {
            /* if (string.IsNullOrWhiteSpace(estado)){
                throw new ArgumentException("");        esta no hace falta, ya que al ser discreto
            }                                           en la UI, no puede ser nunca nulo en parametro
                                                        tampoco va a llegar mal escrito, no se necesitan validaciones
            */
            return await _PromocionRepository.PromosXestadoAsync(estado);

        }

        public async Task<bool> ExpirarPromoAsync(int PromocionId)
        {
            if(PromocionId == 0) //no se como hacerlo, porque al no ser string no puedo hacer string.IsNullOrWhiteSpace()...
            {
                throw new ArgumentNullException("El id no puede ser nulo");
            }
            
            if(PromocionId < 0) {
                throw new ArgumentException("No existen promociones con IDs negativos");
            }
            
            return await _PromocionRepository.ExpirarPromoAsync(PromocionId); //aca va a ir la logica de negocio para expirar la promo, que es cambiar el estado a "expirada" y devolver la promo expirada.

            /* pseudocodigo:
            resultado = FindAsync(int PromocionId)
            if resultado = null){
                throw new ArgumentException("No existe ninguna promocion con dicha ID);
                }
             */
        }

    }
}
