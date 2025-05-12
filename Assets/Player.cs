using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int Vida { get; private set; }
    public int Daño { get; private set; }
    public int DurabilidadArma { get; private set; }

    public Player(int vida = 100, int daño = 20, int durabilidad = 5)
    {
        Vida = vida;
        Daño = daño;
        DurabilidadArma = durabilidad;
    }

    public void Atacar(Enemy enemigo)
    {
        if (DurabilidadArma <= 0)
            throw new Exception("El arma del jugador está rota y no puede atacar.");

        int dañoAleatorio = UnityEngine.Random.Range(Daño / 2, Daño + 1);
        enemigo.RecibirDanio(dañoAleatorio);

        int desgaste = UnityEngine.Random.Range(1, 3);
        DurabilidadArma -= desgaste;

        Debug.Log($"Jugador ataca al enemigo causando {dañoAleatorio} de daño. Durabilidad del arma restante: {DurabilidadArma}");
    }

    public void RecibirDanio(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log($"Jugador recibe {cantidad} de daño. Vida restante: {Vida}");

        if (Vida <= 0)
            throw new Exception("El jugador ha muerto.");
    }
}
