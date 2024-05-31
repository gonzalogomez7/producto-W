using System.Security.Cryptography.X509Certificates;

namespace name
{
    public class producto
    {
        public string codigo {get; set;}
        public string nombre {get; set;}
        public double precio {get; set;}
        public int stock {get; set;}

    
     public producto()
    {
        codigo = "";
        nombre = "Sin nombre";
        precio = 0;
        stock = 0;
    }
    
    public producto(string Nombre, string Codigo)
    {
        string nombre = Nombre;
        string codigo = Codigo;
        this.precio=precio;
        this.stock=stock;
        

    }
    }
    
}

