namespace MiApp

{

    public class Nota

    {

        public double Valor { get; set; }

 

        public Nota(double valor)
        {

            if (valor < 0 || valor > 10)

                throw new ArgumentOutOfRangeException("valor", "El valor debe estar entre 0 y 10");



            Valor = valor;

        }

 

        public string ObtenerCalificacion()
        {

            if (Valor < 5)

                return "Suspenso";

            else if (Valor >= 5 && Valor <= 6)

                return "Aprobado";

            else if (Valor > 6 && Valor <= 7)

                return "Bien";

            else if (Valor > 7 && Valor <= 9)

                return "Notable";

            else

                return "Sobresaliente";

        }

        public override bool Equals(object? obj) 
        { 
            if (obj == null) return false; 
            if (obj is not Nota otra) return false; 
            return Valor == otra.Valor; 
        } 
        
        public override int GetHashCode() 
        { 
            return Valor.GetHashCode(); 
        }

    }

}