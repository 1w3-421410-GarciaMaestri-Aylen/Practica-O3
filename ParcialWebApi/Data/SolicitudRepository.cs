using ParcialWebApi.Models;

namespace ParcialWebApi.Data
{
    public class SolicitudRepository : ISolicitudRepository
    {
        private readonly SolicitudesContext _context;
        public SolicitudRepository(SolicitudesContext context)
        {
            _context = context;
        }
        public void Create(Solicitud nvaSolicitud)
        {
            _context.Add(nvaSolicitud);
            _context.SaveChanges();
        }

        public Solicitud GetByTipo(int tipo)
        {
            return _context.Solicitud.Find("Evolutivo");
            /*return _context.Find("Correctivo"); // aca podria hacer un ternario? como? 
            return _context.Find("bug");
            return _context.Solicitudes.Find("Evolutivo");*/
        }

        public void UpdateEstado(Solicitud solicitud) // lo intente hacer con int y pasarle el nro de la solicitud
                                                     // pero eso me obligaria luego a hacer una consulta LINQ??
        {
            _context.Update(solicitud);
            _context.SaveChanges(); // 
        }
    }
}
