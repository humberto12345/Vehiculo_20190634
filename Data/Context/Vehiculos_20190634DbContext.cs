using Vehiculos_20190634.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos_20190634.Data.Context;

public class Vehiculos_20190634DbContext:DbContext,IVehiculos_20190634DbContext
{
    public Vehiculos_20190634DbContext(DbContextOptions options): base (options)
    {

    }
    public virtual DbSet<Vehiculos> Vehiculos {get; set;} = null!;
}
public interface IVehiculos_20190634DbContext
{
 public DbSet<Vehiculos> Vehiculos {get; set;}
}