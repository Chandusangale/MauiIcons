# FontAwesome Demo - Usage Guide

## Quick Start

1. **Build the project:**
   ```bash
   cd FontAwesomeDemo
   dotnet build -f net10.0-android
   ```

2. **Run the app:**
   ```bash
   dotnet build -f net10.0-android -t:Run
   ```

## Understanding the Code

### Font Registration (MauiProgram.cs)

The FontAwesome fonts must be registered before they can be used:

```csharp
.ConfigureFonts(fonts =>
{
    fonts.AddFont("fa-solid.ttf", "FontAwesomeSolid");
    fonts.AddFont("fa-regular.ttf", "FontAwesomeRegular");
    fonts.AddFont("fa-brands.ttf", "FontAwesomeBrands");
});
```

The second parameter ("FontAwesomeSolid", etc.) is the font family name you'll use in XAML.

### Icon Constants (FontAwesomeIcons.cs)

This helper class provides easy-to-use constants for each icon:

```csharp
public static class FontAwesomeIcons
{
    public const string Home = "\uf015";      // Home icon
    public const string User = "\uf007";      // User icon
    public const string Settings = "\uf013";   // Settings icon
    // ... more icons
}
```

Each constant is the Unicode character for that specific icon.

### Using Icons in Different Controls

#### 1. Label with Icon

```xml
<Label FontFamily="FontAwesomeSolid" 
       Text="{x:Static local:FontAwesomeIcons.Home}"
       FontSize="24"
       TextColor="#512BD4"/>
```

**Key Points:**
- Use `FontFamily` to specify which FontAwesome font to use
- Use `Text` binding to reference the icon constant
- Adjust `FontSize` to change icon size
- Use `TextColor` to change icon color

#### 2. Button with Icon

```xml
<Button Text="Like">
    <Button.ImageSource>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Heart}" 
                       Color="White" />
    </Button.ImageSource>
</Button>
```

**Key Points:**
- Use `FontImageSource` in the `ImageSource` property
- Use `Glyph` instead of `Text` for FontImageSource
- Icon appears next to the button text
- Color can be set independently of the button text

#### 3. ImageButton (Icon Only)

```xml
<ImageButton BackgroundColor="#512BD4"
            CornerRadius="8"
            HeightRequest="50"
            WidthRequest="50"
            Clicked="OnImageButtonClicked">
    <ImageButton.Source>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Camera}" 
                       Color="White" />
    </ImageButton.Source>
</ImageButton>
```

**Key Points:**
- Perfect for icon-only buttons
- Set `HeightRequest` and `WidthRequest` for button size
- Icon scales automatically to fit the button

#### 4. ToolbarItem

```xml
<ContentPage.ToolbarItems>
    <ToolbarItem Order="Primary">
        <ToolbarItem.IconImageSource>
            <FontImageSource FontFamily="FontAwesomeSolid" 
                           Glyph="{x:Static local:FontAwesomeIcons.Settings}" 
                           Color="White" />
        </ToolbarItem.IconImageSource>
    </ToolbarItem>
</ContentPage.ToolbarItems>
```

**Key Points:**
- Use `IconImageSource` for toolbar icons
- `Order="Primary"` makes it appear in the main toolbar
- Color typically should be "White" for visibility on colored toolbars

#### 5. TabbedPage Icons

```xml
<TabbedPage>
    <ContentPage Title="Controls" IconImageSource="dotnet_bot.png">
        <!-- Page content -->
    </ContentPage>
</TabbedPage>
```

**Note:** In this demo, we're using regular images for tab icons, but you can also use FontAwesome icons with FontImageSource.

#### 6. CollectionView with Icons

```xml
<CollectionView x:Name="IconsCollection">
    <CollectionView.ItemsLayout>
        <GridItemsLayout Orientation="Vertical" Span="3"/>
    </CollectionView.ItemsLayout>
    <CollectionView.ItemTemplate>
        <DataTemplate x:DataType="local:IconItem">
            <Frame>
                <VerticalStackLayout>
                    <Label FontFamily="{Binding FontFamily}"
                           Text="{Binding Icon}"
                           FontSize="32"/>
                    <Label Text="{Binding Name}"/>
                </VerticalStackLayout>
            </Frame>
        </DataTemplate>
    </CollectionView.ItemTemplate>
</CollectionView>
```

**In Code-Behind:**
```csharp
Icons = new ObservableCollection<IconItem>
{
    new IconItem { Name = "Home", Icon = FontAwesomeIcons.Home },
    new IconItem { Name = "User", Icon = FontAwesomeIcons.User },
    // ... more icons
};
IconsCollection.ItemsSource = Icons;
```

## Adding New Icons

To add a new icon:

1. **Find the Unicode value** from [FontAwesome's website](https://fontawesome.com/icons)
   - Example: For "Coffee" icon, the unicode is `f0f4`

2. **Add to FontAwesomeIcons.cs:**
   ```csharp
   public const string Coffee = "\uf0f4";
   ```

3. **Use in XAML:**
   ```xml
   <Label FontFamily="FontAwesomeSolid" 
          Text="{x:Static local:FontAwesomeIcons.Coffee}"/>
   ```

## Icon Styles

FontAwesome provides three main styles:

### 1. Solid (FontAwesomeSolid)
- Filled icons
- Most commonly used
- Examples: Home, User, Settings

### 2. Regular (FontAwesomeRegular)
- Outline/hollow icons
- Lighter appearance
- Not all icons available in this style

### 3. Brands (FontAwesomeBrands)
- Brand logos
- Examples: Twitter, Facebook, GitHub
- Different unicode values than Solid/Regular

## Color and Size Customization

### Changing Icon Color

For Label:
```xml
<Label FontFamily="FontAwesomeSolid" 
       Text="{x:Static local:FontAwesomeIcons.Heart}"
       TextColor="Red"/>
```

For FontImageSource:
```xml
<FontImageSource FontFamily="FontAwesomeSolid" 
               Glyph="{x:Static local:FontAwesomeIcons.Heart}" 
               Color="Red" />
```

### Changing Icon Size

For Label:
```xml
<Label FontFamily="FontAwesomeSolid" 
       Text="{x:Static local:FontAwesomeIcons.Heart}"
       FontSize="48"/>
```

For FontImageSource (use Size property):
```xml
<FontImageSource FontFamily="FontAwesomeSolid" 
               Glyph="{x:Static local:FontAwesomeIcons.Heart}" 
               Size="48" />
```

## Common Patterns

### Icon with Text Label

```xml
<HorizontalStackLayout Spacing="10">
    <Label FontFamily="FontAwesomeSolid" 
           Text="{x:Static local:FontAwesomeIcons.Home}"
           FontSize="24"
           VerticalOptions="Center"/>
    <Label Text="Home" 
           FontSize="18"
           VerticalOptions="Center"/>
</HorizontalStackLayout>
```

### Colored Action Buttons

```xml
<!-- Success/Save -->
<Button BackgroundColor="#28A745" TextColor="White">
    <Button.ImageSource>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Check}" 
                       Color="White" />
    </Button.ImageSource>
    <Button.Text>Save</Button.Text>
</Button>

<!-- Danger/Delete -->
<Button BackgroundColor="#DC3545" TextColor="White">
    <Button.ImageSource>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Trash}" 
                       Color="White" />
    </Button.ImageSource>
    <Button.Text>Delete</Button.Text>
</Button>

<!-- Warning/Edit -->
<Button BackgroundColor="#FFC107" TextColor="White">
    <Button.ImageSource>
        <FontImageSource FontFamily="FontAwesomeSolid" 
                       Glyph="{x:Static local:FontAwesomeIcons.Edit}" 
                       Color="White" />
    </Button.ImageSource>
    <Button.Text>Edit</Button.Text>
</Button>
```

## Troubleshooting

### Icons Don't Show Up

1. **Check font registration:** Ensure fonts are registered in `MauiProgram.cs`
2. **Check font family name:** Must match exactly (case-sensitive)
3. **Check font files:** Ensure `.ttf` files are in `Resources/Fonts/`
4. **Verify unicode:** Make sure the icon constant has the correct unicode value

### Icons Show as Squares/Boxes

- The icon unicode doesn't exist in the font file
- You're using a Solid icon with Regular font (or vice versa)
- Font file might be corrupted

### Icons Are Too Small/Big

- Adjust `FontSize` for Labels
- Adjust `Size` property for FontImageSource
- For ImageButtons, adjust `HeightRequest` and `WidthRequest`

## Performance Tips

1. **Reuse FontImageSource:** If using the same icon multiple times, consider creating it as a StaticResource
2. **Lazy loading:** Load icons only when needed, especially in long lists
3. **Cache icons:** The IconItem class caches icon information for better performance

## Resources

- [FontAwesome Icons](https://fontawesome.com/icons) - Browse all available icons
- [FontAwesome License](https://fontawesome.com/license/free) - Free license information
- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/) - Official MAUI docs
