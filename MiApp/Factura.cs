public class Factura

{

    public int Id { get; set; }

    public string Concepto { get; set; }

    public double Importe { get; set; }

 

    public Factura(int id, string concepto, double importe)

    {

        Id = id;

        Concepto = concepto;

        if (importe <= 0)
        {
            throw new Exception("Valor no valido");
        }

        Importe = importe;

    }

    public double calcularIVA()
    {
        return Importe *1.21;
    }

}