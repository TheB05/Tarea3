using System;
using System.ComponentModel.DataAnnotations;

class Reporte{

    public string ID = Guid.NewGuid().ToString();

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required (ErrorMessage = "Necesita introducir una descripción.")]
    [MinLength(10, ErrorMessage = "Debe introducir una descripción con al menos 5 caracteres para que sea válida.")]
    public string Descripcion { get; set; } = "";

    public double CostoEstimado { get; set; } = 0;

    public int Muertos { get; set; } = 0;

    public int Heridos { get; set; } = 0;

    public int VehiculosInvolucrados { get; set; } = 0;
}