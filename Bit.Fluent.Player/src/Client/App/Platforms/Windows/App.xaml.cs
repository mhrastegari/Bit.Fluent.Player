﻿using Microsoft.UI.Xaml;

namespace Bit.Fluent.Player.Client.App.Platforms.Windows;

public partial class App
{
    public App()
    {
        InitializeComponent();
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
