using UnityEngine;

public class PocionVida : Item, IConsumible
{
    public PocionVida()
    {
        Nombre = "Poci�n de Vida";
    }

    public override void Usar()
    {
        Debug.Log("Has usado una Poci�n de Vida. Vida restaurada.");
    }

    public void Consumir()
    {
        Usar();
    }
}

public interface IConsumible
{
    void Consumir();
}
