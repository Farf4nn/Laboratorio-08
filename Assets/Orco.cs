using UnityEngine;

public class Orco : Enemy
{
    public Orco(string nombre) : base(nombre) { }
    public Orco(string nombre, int vida, int ataque, int defensa) : base(nombre, vida, ataque, defensa) { }

    public Orco(string nombre, int v1, int v2) : this(nombre)
    {
    }

    public override Item DropearItem()
    {
        return new PocionVida(); // Dropea una poción de vida
    }

    // Habilidad única
    public void GolpeBrutal(Enemy objetivo)
    {
        int danio = Ataque * 2 - objetivo.Defensa;
        objetivo.RecibirDanio(Mathf.Max(danio, 1));
        Debug.Log($"{Nombre} usa Golpe Brutal en {objetivo.Nombre} causando {danio} de daño.");
    }
    public void AtacarJugador(Player jugador)
    {
        int daño = Random.Range(Ataque / 2, Ataque + 1);
        jugador.RecibirDanio(daño);
    }
}
