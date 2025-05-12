using UnityEngine;

public class Esqueleto : Enemy
{
    public Esqueleto(string nombre) : base(nombre) { }
    public Esqueleto(string nombre, int vida, int ataque, int defensa) : base(nombre, vida, ataque, defensa) { }

    public override Item DropearItem()
    {
        return new BuffItem();
    }

    // Habilidad única
    public void LanzarHueso(Enemy objetivo)
    {
        int danio = Ataque - objetivo.Defensa / 2;
        objetivo.RecibirDanio(Mathf.Max(danio, 1));
        Debug.Log($"{Nombre} lanza un hueso a {objetivo.Nombre} causando {danio} de daño.");
    }
}
