# MauiIcons - FontAwesome Demo

A .NET MAUI application demonstrating the use of FontAwesome icons across different controls and platforms.

## Overview

This project showcases how to integrate and use FontAwesome icons in a .NET MAUI application. It demonstrates icon usage in various MAUI controls including:

- **Label** - Text labels with icons
- **Button** - Buttons with icon images
- **ImageButton** - Icon-only buttons
- **ToolbarItem** - Toolbar icons
- **TabbedPage** - Tab bar icons
- **CollectionView** - Grid of icons with names

## Features

### Tab 1: Controls Demo
- Demonstrates FontAwesome icons in different UI controls
- ToolbarItems with Settings and Bell icons
- Labels with Home icon
- Button with Heart icon
- ImageButton with Camera icon
- Action buttons (Save, Delete, Edit) with appropriate icons

### Tab 2: Icons Gallery
- Grid display of 40+ common FontAwesome icons
- Each icon shown with its name
- Icons include: Home, User, Settings, Search, Heart, Star, Bell, and many more

## Project Structure

```
FontAwesomeDemo/
├── App.xaml                    # Application resources
├── App.xaml.cs                 # Application code-behind
├── MainPage.xaml               # Main page with TabbedPage layout
├── MainPage.xaml.cs            # Main page code-behind with icon loading
├── FontAwesomeIcons.cs         # Helper class with icon unicode constants
├── MauiProgram.cs              # MAUI app configuration with font registration
├── Resources/
│   └── Fonts/
│       ├── fa-solid.ttf        # FontAwesome Solid font
│       ├── fa-regular.ttf      # FontAwesome Regular font
│       └── fa-brands.ttf       # FontAwesome Brands font
└── FontAwesomeDemo.csproj      # Project file
```

## Setup Instructions

### Prerequisites
- .NET 10.0 SDK
- MAUI workload installed

### Font Configuration

The FontAwesome fonts are registered in `MauiProgram.cs`:

```csharp
.ConfigureFonts(fonts =>
{
    fonts.AddFont("fa-solid.ttf", "FontAwesomeSolid");
    fonts.AddFont("fa-regular.ttf", "FontAwesomeRegular");
    fonts.AddFont("fa-brands.ttf", "FontAwesomeBrands");
});
```

### Using FontAwesome Icons

#### In XAML

**Label:**
```xml
<Label FontFamily="FontAwesomeSolid" 
       Text="{x:Static local:FontAwesomeIcons.Home}"
       FontSize="24"/>
```

**Button:**
```xml
<Button Text="Like">
    <Button.ImageSource>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Heart}" 
                       Color="White" />
    </Button.ImageSource>
</Button>
```

**ImageButton:**
```xml
<ImageButton>
    <ImageButton.Source>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Camera}" 
                       Color="White" />
    </ImageButton.Source>
</ImageButton>
```

**ToolbarItem:**
```xml
<ToolbarItem>
    <ToolbarItem.IconImageSource>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Settings}" 
                       Color="White" />
    </ToolbarItem.IconImageSource>
</ToolbarItem>
```

## Building and Running

### Build
```bash
dotnet build -f net10.0-android
```

### Run on Android
```bash
dotnet build -f net10.0-android -t:Run
```

## Icon Helper Class

The `FontAwesomeIcons.cs` file contains unicode constants for easy icon access:

```csharp
public static class FontAwesomeIcons
{
    public const string Home = "\uf015";
    public const string User = "\uf007";
    public const string Settings = "\uf013";
    // ... more icons
}
```

## Platform Support

This demo is configured for Android. To add support for other platforms, modify the `TargetFrameworks` in `FontAwesomeDemo.csproj`:

```xml
<TargetFrameworks>net10.0-android;net10.0-ios;net10.0-maccatalyst</TargetFrameworks>
```

## Font Families

Three FontAwesome font families are available:

- **FontAwesomeSolid** - Solid style icons (most common)
- **FontAwesomeRegular** - Regular/outline style icons
- **FontAwesomeBrands** - Brand logos (Twitter, Facebook, etc.)

## License

FontAwesome fonts are licensed under the Font Awesome Free License. See [FontAwesome.com](https://fontawesome.com/license/free) for details.

## Credits

- FontAwesome Icons: https://fontawesome.com/
- .NET MAUI: https://dotnet.microsoft.com/apps/maui
