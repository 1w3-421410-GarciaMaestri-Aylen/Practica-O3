using ParcialWebApi.Models;

namespace ParcialWebApi.Data
{
    public interface ISolicitudRepository
    {
        public List<Solicitud> GetAll();
        public Solicitud GetByTipo (string tipo);

        public void Create (Solicitud nvaSolicitud);

        public void UpdateEstado(Solicitud solicitud);
    }
}
