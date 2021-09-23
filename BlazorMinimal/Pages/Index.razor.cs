
using Microsoft.AspNetCore.Components;

namespace BlazorMinimal.Pages
{
    public partial class Index
    {        
        string title = "Client-side (Web Assembly) Blazor Minimal";
        string GetTextFromMethodInClass()
        {
            return "This text is derived from a C# .cs file within the assembly";
        }

    }
}
