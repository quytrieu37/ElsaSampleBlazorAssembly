using Elsa.Studio;
using Elsa.Studio.Contracts;
using Elsa.Studio.Models;
using Microsoft.AspNetCore.Components;
using SampleBlazorAssembly.UIHint.Components;

namespace SampleBlazorAssembly.UIHint.Handlers;

public class TreeUIHintHandler : IUIHintHandler
{
    public bool GetSupportsUIHint(string uiHint) => uiHint == "tree";
    public string UISyntax => WellKnownSyntaxNames.Literal;

    public RenderFragment DisplayInputEditor(DisplayInputEditorContext context)
    {
        return builder =>
        {
            builder.OpenComponent(0, typeof(TreeUIHint));
            builder.AddAttribute(1, nameof(TreeUIHint.EditorContext), context);
            builder.CloseComponent();
        };
    }
}