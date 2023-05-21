﻿using Robust.Shared.Prototypes;

namespace Content.Client.Corvax.GhostTheme;

[Prototype("ghostTheme")]
public sealed class GhostThemePrototype : IPrototype
{
    /// <inheritdoc/>
    [IdDataField]
    public string ID { get; } = default!;

    [DataField("name")] public string Name { get; set; } = "";

    [DataField("icon")] public string Icon { get; private set; } = string.Empty;
}
