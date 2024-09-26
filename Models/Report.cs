

class Reporte{

    public string ID = Guid.NewGuid().ToString();
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string Descripcion { get; set; } = "";
    public double CostoEstimado { get; set; } = 0;
    public int Muertos { get; set; } = 0;
    public int Heridos { get; set; } = 0;
    public int VehiculosInvolucrados { get; set; } = 0;
}