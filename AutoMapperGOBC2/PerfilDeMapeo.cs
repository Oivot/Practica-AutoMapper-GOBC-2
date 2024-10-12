using AutoMapper;
using AutoMapperGOBC2.Models;

namespace AutoMapperGOBC2;

public class PerfilDeMapeo : Profile
{
    public PerfilDeMapeo()
    {
        CreateMap<Producto, ProductoDTO>();
    }
}
