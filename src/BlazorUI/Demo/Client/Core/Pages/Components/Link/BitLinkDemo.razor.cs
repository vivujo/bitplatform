﻿namespace Bit.BlazorUI.Demo.Client.Core.Pages.Components.Link;

public partial class BitLinkDemo
{
    private readonly List<ComponentParameter> componentParameters = new()
    {
        new()
        {
            Name = "ChildContent",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "The content of link, can be any custom tag or a text.",
        },
        new()
        {
            Name = "HasUnderline",
            Type = "bool",
            DefaultValue = "false",
            Description = "Whether the link is styled with an underline or not.",
        },
        new()
        {
            Name = "Href",
            Type = "string",
            DefaultValue = "string.Empty",
            Description = "URL the link points to.",
        },
        new()
        {
            Name = "OnClick",
            Type = "EventCallback<MouseEventArgs>",
            Description = "Callback for when the action button clicked.",
        },
        new()
        {
            Name = "Target",
            Type = "string?",
            DefaultValue = "null",
            Description = "If Href provided, specifies how to open the link.",
        }
    };



    private readonly string example1RazorCode = @"
<BitLink Href=""https://github.com/bitfoundation/bitplatform"">Basic Link</BitLink>
<BitLink Href=""https://github.com/bitfoundation/bitplatform"" IsEnabled=""false"">Disabled Link</BitLink>
";

    private readonly string example2RazorCode = @"
<style>
    .custom-class {
        padding: 0 0.5rem;
        border: 1px solid red;
        max-width: max-content;
    }
</style>

<BitLink Style=""color: goldenrod; font-weight:bold"" Href=""https://github.com/bitfoundation/bitplatform"">Link with style</BitLink>
<BitLink Class=""custom-class"" Href=""https://github.com/bitfoundation/bitplatform"">Link with class</BitLink>";

    private readonly string example3RazorCode = @"
<BitLink Href=""https://github.com/bitfoundation/bitplatform"" HasUnderline=""true"">Underlined link</BitLink>";

    private readonly string example4RazorCode = @"
<BitLink Href=""https://github.com/bitfoundation/bitplatform"" Target=""_blank"">Blank target link</BitLink>
<BitLink Href=""https://github.com/bitfoundation/bitplatform"" Target=""_parent"">Parent target link</BitLink>
<BitLink Href=""https://github.com/bitfoundation/bitplatform"" Target=""_self"">Self target link</BitLink>
<BitLink Href=""https://github.com/bitfoundation/bitplatform"" Target=""_top"">Top target link</BitLink>";

    private readonly string example5RazorCode = @"
<BitLink OnClick=""LinkOnClick"">Link with OnClick</BitLink>";
    private readonly string example5CsharpCode = @"
[Inject] private NavigationManager Navigation { get; set; } = default!;

private void LinkOnClick()
{
    // Here you can do something else...

    Navigation.NavigateTo(""https://github.com/bitfoundation/bitplatform"");
}";

    private readonly string example6RazorCode = @"
Visible: [ <BitLink Visibility=""BitVisibility.Visible"">Visible Link</BitLink> ]
Hidden: [ <BitLink Visibility=""BitVisibility.Hidden"">Hidden Link</BitLink> ]
Collapsed: [ <BitLink Visibility=""BitVisibility.Collapsed"">Collapsed Link</BitLink> ]";

    private readonly string example7RazorCode = @"
<BitLink Style=""scroll-margin: 70px"" id=""start-article"" Href=""#end-article"">Go To End of this Article</BitLink>
<p>
    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas lorem nulla, malesuada ut sagittis sit
    amet, vulputate in leo. Maecenas vulputate congue sapien eu tincidunt. Etiam eu sem turpis. Fusce tempor
    sagittis nunc, ut interdum ipsum vestibulum non. Proin dolor elit, aliquam eget tincidunt non, vestibulum ut
    turpis. In hac habitasse platea dictumst. In a odio eget enim porttitor maximus. Aliquam nulla nibh,
    ullamcorper aliquam placerat eu, viverra et dui. Phasellus ex lectus, maximus in mollis ac, luctus vel eros.
    Vivamus ultrices, turpis sed malesuada gravida, eros ipsum venenatis elit, et volutpat eros dui et ante.
    Quisque ultricies mi nec leo ultricies mollis. Vivamus egestas volutpat lacinia. Quisque pharetra eleifend
    efficitur.
</p>
<p>
    Mauris at nunc eget lectus lobortis facilisis et eget magna. Vestibulum venenatis augue sapien, rhoncus
    faucibus magna semper eget. Proin rutrum libero sagittis sapien aliquet auctor. Suspendisse tristique a
    magna at facilisis. Duis rhoncus feugiat magna in rutrum. Suspendisse semper, dolor et vestibulum lacinia,
    nunc felis malesuada ex, nec hendrerit justo ex et massa. Quisque quis mollis nulla. Nam commodo est ornare,
    rhoncus odio eu, pharetra tellus. Nunc sed velit mi.
</p>
<p>
    Sed condimentum ultricies turpis convallis pharetra. Sed sagittis quam pharetra luctus porttitor. Cras vel
    consequat lectus. Sed nec fringilla urna, a aliquet libero. Aenean sed nisl purus. Vivamus vulputate felis
    et odio efficitur suscipit. Ut volutpat dictum lectus, ac rutrum massa accumsan at. Sed pharetra auctor
    finibus. In augue libero, commodo vitae nisi non, sagittis convallis ante. Phasellus malesuada eleifend
    mollis. Curabitur ultricies leo ac metus venenatis elementum.
</p>
<p>
    Aenean egestas quam ut erat commodo blandit. Mauris ante nisl, pellentesque sed venenatis nec, aliquet sit
    amet enim. Praesent vitae diam non diam aliquet tristique non ut arcu. Pellentesque et ultrices eros. Fusce
    diam metus, mattis eu luctus nec, facilisis vel erat. Nam a lacus quis tellus gravida euismod. Nulla sed sem
    eget tortor cursus interdum. Sed vehicula tristique ultricies. Aenean libero purus, mollis quis massa quis,
    eleifend dictum massa. Fusce eu sapien sit amet odio lacinia placerat. Mauris varius risus sed aliquet
    cursus. Aenean lectus magna, tincidunt sit amet sodales a, volutpat ac leo. Morbi nisl sapien, tincidunt sit
    amet mauris quis, sollicitudin auctor est.
</p>
<p>
    Nam id mi justo. Nam vehicula vulputate augue, ac pretium enim rutrum ultricies. Sed aliquet accumsan
    varius. Quisque ac auctor ligula. Fusce fringilla, odio et dignissim iaculis, est lacus ultrices risus,
    vitae condimentum enim urna eu nunc. In risus est, mattis non suscipit at, mattis ut ante. Maecenas
    consectetur urna vel erat maximus, non molestie massa consequat. Duis a feugiat nibh. Sed a hendrerit diam,
    a mattis est. In augue dolor, faucibus vel metus at, convallis rhoncus dui.
</p>

<BitLink Style=""scroll-margin: 70px"" id=""end-article"" Href=""#start-article"">Go To Start of this Article</BitLink>
";
}
