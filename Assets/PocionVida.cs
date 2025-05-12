using UnityEngine;

public class PocionVida : Item, IConsumible
{
    public PocionVida()
    {
        Nombre = "Poción de Vida";
    }

    public override void Usar()
    {
        Debug.Log("Has usado una Poción de Vida. Vida restaurada.");
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
