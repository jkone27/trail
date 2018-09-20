﻿namespace BlazorApp1.Pages

open Microsoft.AspNetCore.Blazor.Components
open Microsoft.AspNetCore.Blazor.Layouts
open BlazorApp1.Shared
open Trail

[<LayoutAttribute(typeof<MainLayout>)>]
[<RouteAttribute("/")>]
type Index () =
    inherit Trail.Component()

    override __.Render() =
        Dom.Fragment [
            Dom.h1 [] [ Dom.text "Hello, world!" ]
            Dom.text "\n\nWelcome to your new app.\n\n"
            Dom.comp<SurveyPrompt> [Dom.HtmlAttribute("title", "How is Blazor working for you?")] []
        ]
