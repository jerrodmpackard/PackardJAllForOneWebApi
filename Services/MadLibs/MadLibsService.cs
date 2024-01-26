namespace PackardJAllForOneWebApi.Services.MadLibs;

public class MadLibsService : IMadLibsService
{
    public string MadLibs(string heroName, string planetName, string speciesName, string pluralNoun, string noun5, string noun6, string verb1, string verb2, string adj1, string adj2)
    {
        return $"Long ago, in a galaxy far, far away, we join our hero, Captain {heroName} of the Rebel Alliance, on the planet {planetName}.\nAfter {verb1} from the {speciesName}, Captain {heroName} wound up on a strange planet.\nThis strange planet contained many {adj1} {pluralNoun} that wanted to {verb2} our hero.\nCaptain {heroName} narrowly dodges a trap set by the {planetName} locals.\nSuddenly, an incoming transmission from the leader of the Rebel Alliance, Commander Leia Organa.\n\"Captain {heroName}, do you read me?\"\n\"You must infiltrate the {adj2} Imperial Fortress and transmit blueprints for their next {noun5}...\"\nThe transmission is cut short as Imperial Stormtroopers suddenly surround Captain {heroName} and our hero is captured.\n\"Oh no, not {noun6}!\" our hero exclaims.\n\"Anything but {noun6}!\"\nWill our hero survive? Will Captain {heroName} complete their mission?\nFind out on the next exciting episode!";
    }
}
