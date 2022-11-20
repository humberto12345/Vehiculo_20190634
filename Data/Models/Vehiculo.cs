using System.ComponentModel.DataAnnotations;
using Vehiculos_20190634.Data.Context;

namespace Vehiculos_20190634.Data.Models;

public class Vehiculos
{
    [Key]
    public int VehiculoID { get; set; }
    public string? Marca { get; set; } 
    public string? Modelo { get; set; }
    public int Año { get; set; }
    public string? Color { get; set; }
}
