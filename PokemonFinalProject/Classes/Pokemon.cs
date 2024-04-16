using System.Runtime.Serialization;
using System.Security.Authentication.ExtendedProtection;

namespace PokemonFinalProject.Classes;

public class Pokemon
{
    public Pokemon(string name, int health, int atk, PokemonType pokemonType)
    {
        _name = name;
        _health = health;
        _atk = atk;
        _ptype = pokemonType;
    }
    private string _name;
    private int _health;
    private int _atk;
    private PokemonType _ptype;
    
    public string Name
    {
        get => _name;
    }

    public int Health
    {
        get => _health;
    }

    public int Atk
    {
        get => _atk;
    }

    public PokemonType PokemonType
    {
        get => _ptype;
    }
    
    public void TakeDamage(int _damage)
    {
        _health -= _damage;
    }

    public int Attack(Pokemon p)
    {
        int damage = _atk;
        if (_ptype == PokemonType.Feu)
        {
            if (p.PokemonType == PokemonType.Plante)
            {
                damage *= 2;
                
            }else if (p.PokemonType == PokemonType.Eau || p.PokemonType == PokemonType.Feu)
            {
                damage /= 2;
            }
        } else if (_ptype == PokemonType.Eau)
        {
            if (p.PokemonType == PokemonType.Feu)
            {
                damage *= 2;
                
            }else if (p.PokemonType == PokemonType.Eau || p.PokemonType == PokemonType.Plante)
            {
                damage /= 2;
            }
        } else if (_ptype == PokemonType.Plante)
        {
            if (p.PokemonType == PokemonType.Eau)
            {
                damage *= 2;
                
            }else if (p.PokemonType == PokemonType.Feu || p.PokemonType == PokemonType.Plante)
            {
                damage /= 2;
            }
        }
        
        
        p.TakeDamage(damage);

        return damage;
    }
    public bool IsDead() => _health <= 0;
}