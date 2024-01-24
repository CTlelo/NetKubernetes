using NetKubernetes.Models;

namespace NetKubernetes.Data.Inmuebles;

public interface IInmuebleRepository{

    bool SaveChanges();

    IEnumerable<Inmueble> GetAllInmuebles();

    Inmueble GetInmuebleById(int id);

    Task CreateImueble(Inmueble inmueble);

    void DeleteImueble(int id);
}