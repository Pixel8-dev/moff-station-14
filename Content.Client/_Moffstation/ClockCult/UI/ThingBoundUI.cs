using JetBrains.Annotations;
using Robust.Client.GameObjects;
using Robust.Client.UserInterface;
using Content.Client._Moffstation.ClockCult.UI;

namespace Content.Client._Moffstation.ClockCult.UI;

[UsedImplicitly]
public sealed class ThingBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private ThingWindow? _window;

    public ThingBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }

    protected override void Open()
    {
        base.Open();

        _window = this.CreateWindow<ThingWindow>();
    }
}
