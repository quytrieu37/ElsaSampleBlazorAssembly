using Elsa.Studio.Components;
using Elsa.Studio.Models;
using Microsoft.AspNetCore.Components;

namespace SampleBlazorAssembly.UIHint.Components;

public partial class TreeUIHint : StudioComponentBase
{
    [Parameter]
    public DisplayInputEditorContext EditorContext { get; set; } = default!;
}