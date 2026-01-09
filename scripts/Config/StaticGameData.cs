using Godot;
using Godot.Collections;

namespace SimpleClicker.Config;

[GlobalClass]
public partial class StaticGameData : Resource
{
    [Export] public Array<CurrencyDefinition> Currencies = new();
    [Export] public Array<GeneratorDefinition> Generators = new();
    [Export] public Array<ManagerDefinition> Managers = new();
}