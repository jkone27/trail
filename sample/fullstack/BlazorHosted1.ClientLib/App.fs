﻿namespace BlazorHosted1.Client

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open System.Net.Http
open Microsoft.AspNetCore.Blazor
open Microsoft.AspNetCore.Blazor.Browser.Rendering
open Microsoft.AspNetCore.Blazor.Browser.Services
open Microsoft.AspNetCore.Blazor.Components
open Microsoft.AspNetCore.Blazor.Layouts
open Microsoft.AspNetCore.Blazor.Routing
open BlazorHosted1.Client
open BlazorHosted1.Shared
open Trail

type App() =
    inherit Trail.Component()

    override __.Render() =
        Dom.router<Router> typeof<App>.Assembly
