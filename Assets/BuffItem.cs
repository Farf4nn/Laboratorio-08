using UnityEngine;

public class BuffItem : Item, IAplicarBuff
{
    public BuffItem()
    {
        Nombre = "Buff de Fuerza";
    }

    public override void Usar()
    {
        Debug.Log("Has aplicado un Buff de Fuerza. ¡Ataque aumentado!");
    }

    public void AplicarBuff()
    {
        Usar();
    }
}

public interface IAplicarBuff
{
    void AplicarBuff();
}
