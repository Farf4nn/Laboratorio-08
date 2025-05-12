using UnityEngine;

public abstract class Item
{
    public string Nombre { get; protected set; }
    public abstract void Usar();
}
