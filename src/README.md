# MauiIcons - Material Icons Round

This package provides Material Icons Round font integration for .NET MAUI applications.

## Setup Instructions

### Adding the Font File

The MaterialIconsRound.ttf font file is not included in this repository. You need to obtain and add it manually.

#### Steps:

1. **Download the Font**
   - Visit [Google Fonts - Material Icons](https://fonts.google.com/icons)
   - Download the Material Icons Round variant
   - Or obtain it from the [Material Design Icons repository](https://github.com/google/material-design-icons)

2. **Add to Project**
   - Create the directory `src/Resources/Fonts/` if it doesn't exist
   - Copy the `MaterialIconsRound.ttf` file to `src/Resources/Fonts/`

3. **Verify Project Configuration**
   - The `.csproj` file already contains the font reference:
     ```xml
     <MauiFont Include="Resources\Fonts\MaterialIconsRound.ttf" Alias="MaterialIconsRound" />
     ```

## Usage

### Using Icon Glyphs

```csharp
using MauiIcons.Icons;

// Get a glyph for a specific icon
string homeIcon = MaterialIconsRound.GetGlyph("Home");

// Or access the dictionary directly
string searchIcon = MaterialIconsRound.Glyphs["Search"];
```

### In XAML

```xml
<!-- Option 1: Using the FontAlias constant -->
<Label 
    Text="&#xe88a;" 
    FontFamily="{x:Static local:MaterialIconsRound.FontAlias}"
    FontSize="24" />

<!-- Option 2: Set text in code-behind using GetGlyph() -->
<Label 
    x:Name="MyIcon"
    FontFamily="MaterialIconsRound"
    FontSize="24" />
```

For the second option, set the text in code-behind:
```csharp
MyIcon.Text = MaterialIconsRound.GetGlyph("Home");
```

### In C#

```csharp
var label = new Label
{
    Text = MaterialIconsRound.GetGlyph("Settings"),
    FontFamily = MaterialIconsRound.FontAlias,
    FontSize = 24
};
```

## Available Icons

The helper class includes common Material Icons such as:
- Home
- Search
- Settings
- Person
- Favorite
- Add, Remove, Close
- Menu
- Navigation arrows
- Check, Delete, Edit
- Refresh, Share, Star
- Info, Warning, Error

For a complete list of available icons and their Unicode values, refer to the [Material Icons documentation](https://fonts.google.com/icons).

## License

Material Icons are provided by Google under the Apache License 2.0. Please refer to Google's licensing terms for usage.
