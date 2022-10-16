// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace CleanArchitecture.Blazor.Infrastructure.Configurations;

public class DashbordSettings
{
    public const string SectionName = nameof(DashbordSettings);
   
    public string Version { get; set; }="6.0.2";
    public string App { get; set; } = "Dashboard";
    public string AppName { get; set; } = "Visitor Management System";
    public string AppFlavor { get; set; } = String.Empty;
    public string AppFlavorSubscript { get; set; } = String.Empty;

    public string Company { get; set; } = "SecurityOne";
    public string Copyright { get; set; } = "@2022 Copyright";

}
