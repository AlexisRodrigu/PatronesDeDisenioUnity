public class Ruedas
{
    public string marca;
    public int grosor;
    public int cantidad;
    
    public enum ColorRueda
    {
        azul,negro,blanco,rojo
    }
    public ColorRueda _colorRueda;

    
    //Objeto de rines
    public Rines rines = new Rines();
}