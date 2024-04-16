
using PokemonFinalProject.Classes;

Pokemon waterP = new Pokemon("Tsunami", 150, 10, PokemonType.Eau);
Pokemon fireP = new Pokemon("Volcan", 175, 5, PokemonType.Eau);
Pokemon plantP = new Pokemon("Tree", 250, 7, PokemonType.Eau);
SimManager simManager = new SimManager(waterP, plantP);

simManager.StartSimulation();