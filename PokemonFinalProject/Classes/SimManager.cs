namespace PokemonFinalProject.Classes;

public class SimManager
{

    public SimManager(Pokemon pokemon1, Pokemon pokemon2)
    {
        _pokemon1 = pokemon1;
        _pokemon2 = pokemon2;
    }
    private Pokemon _pokemon1;
    private Pokemon _pokemon2;

    private int _turn;

    public Pokemon Pokemon1
    {
        get => _pokemon1;
        set
        {
            _pokemon1 = value;
        }
    }

    public Pokemon Pokemon2
    {
        get => _pokemon2;
        set
        {
            _pokemon2 = value;
        }
    }

    public void StartSimulation()
    {
        while (!Pokemon1.IsDead() && !Pokemon2.IsDead())
        {
            if (_turn % 2 == 0)
            {
                int inflictedDamage = _pokemon1.Attack(_pokemon2);
                Console.WriteLine($"{_pokemon1.Name} ({_pokemon1.Health}hp) attaque {_pokemon2.Name} ({_pokemon2.Health}hp), et lui inflige {inflictedDamage} points de degats !");
            }
            else
            {
                int inflictedDamage = _pokemon2.Attack(_pokemon1);
                Console.WriteLine($"{_pokemon2.Name} ({_pokemon2.Health}hp) attaque {_pokemon1.Name} ({_pokemon1.Health}hp), et lui inflige {inflictedDamage} points de degats !");
            }

            _turn++;
        }

        Pokemon winner = _turn % 2 == 0 ? _pokemon2 : _pokemon1;
        Console.WriteLine($"LE GAGNANT EST {winner.Name}");
    }
}