using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public enum NpvBodyGender
{
    Female = 0,
    Male = 1,
}

// ReSharper disable InconsistentNaming I'm gonna name these like they are in the file >.<
public enum EyeColorAppearances
{
    gradient_red,
    gradient_grey,
    multilayer_spider,
    gradient_light_blue,
    gradient_brown,
    gradient_black,
    blood_gradient_blue,
    multilayer_arasaka,
    multilayer_spiral_black,
    blood_gradient_grey,
    multilayer_lizzard,
    blood_gradient_brown,
    blood_gradient_light_blue,
    blood_gradient_red,
    gradient_blue,
    multilayer_target,
    gradient_yellow,
    multilayer_arasaka_black,
    blood_gradient_yellow,
    multilayer_black,
    blood_gradient_green,
    blood_gradient_black,
    multilayer_cpu,
    multilayer_x_sign,
    gradient_violet,
    multilayer_target_black,
    multilayer_spiral,
    multilayer_x_sign_black,
    multilayer_heart_black,
    gradient_green,
    multilayer_cpu_black,
    multilayer_ring,
    multilayer_spider_black,
    multilayer_ring_black,
    multilayer_lizzard_black,
    multilayer_heart,
    multilayer_skull,
    blood_gradient_violet,
}

public enum EyeMakeupColorAppearances
{
    black,
    blue,
    gold,
    green,
    pink,
    red,
    violet,
    white,
    yellow,
    orange,
    teal,
    grey,
    brown,
    neon_yellow
}

public enum LipMakeupColorAppearances
{
    black,
    blue,
    gold,
    green,
    pink,
    red,
    violet,
    white,
    yellow,
    peach,
    burgundy,
    brown,
    scarlet,
    pastel_pink
}

public enum FrecklesMakeupColorAppearances
{
    freckles_brown_01,
    freckles_brown_02,
    freckles_brown_03,
    freckles_brown_04,
    brown,
    pink,
    red,
    golden_brown,
    peach,
    raspberry,
    magenta,
    green
}

public enum HairColorAppearances
{
    blonde_platinum,
    red_merlot,
    blue_sapphire,
    black_salt_n_pepper,
    brown_ombre,
    liliac,
    red_apple,
    ginger_copper,
    teal_ombre,
    gray_gunmetal,
    goblin_green,
    brown_liquorice,
    ginger_strawberry,
    blue_red_ombre,
    pink_magenta,
    cyberpunk_yellow,
    teal_ash,
    green_toxic,
    mermaid_aquamarine,
    black_carbon,
    cold_white,
    purple_ombre,
    blonde_golden,
    pink_rose,
    blonde_dishwater,
    blue_steel,
    brown_medium,
    blue_sky,
    citrus_yellow,
    dark_purple,
    green_orange,
    liliac_ombre,
    phoenix_fire,
    purple_blonde,
    silver_rose
}
// ReSharper enable InconsistentNaming 

public partial class NpvCreationDialogViewModel : DialogViewModel
{
    [ObservableProperty] private string _destFolderPath = "";
    [ObservableProperty] private bool _canSave = false;
    [ObservableProperty] private bool _pageComplete = false;

    [ObservableProperty] private int _currentPage = 0;

    public NpvBodyGender BodyGender = NpvBodyGender.Female;

    public int Eyes = 0;
    public int Nose = 0;
    public int Mouth = 0;
    public int Jaw = 0;
    public int Ears = 0;

    public List<string> CyberwareOptions = Enumerable.Range(0, 10).Select(i => i == 0 ? "" : i.ToString("D2")).ToList();
    public List<string> TattooOptions = Enumerable.Range(0, 12).Select(i => i == 0 ? "" : i.ToString("D2")).ToList();
    public List<string> ScarOptions = Enumerable.Range(0, 10).Select(i => i == 0 ? "" : i.ToString("D2")).ToList();
    public List<string> EyeMakeUpStyleOptions = Enumerable.Range(0, 20).Select(i => i == 0 ? "none" : i.ToString("D2")).ToList();
    public List<string> EyeMakeUpColorOptions = [.. Enum.GetNames(typeof(EyeMakeupColorAppearances))];
    public List<string> LipMakeUpStyleOptions = Enumerable.Range(0, 20).Select(i => i == 0 ? "none" : i.ToString("D2")).ToList();
    public List<string> LipMakeUpColorOptions = [.. Enum.GetNames(typeof(LipMakeupColorAppearances))];
    public List<string> EyebrowStyleOptions = Enumerable.Range(0, 11).Select(i => i == 0 ? "none" : i.ToString("D2")).ToList();
    public List<string> EyebrowColorOptions = [.. Enum.GetNames(typeof(HairColorAppearances))];
    public List<string> BeardStyleOptions = Enumerable.Range(0, 12).Select(i => i == 0 ? "none" : i.ToString("D2")).ToList();
    public List<string> BeardColorOptions = [.. Enum.GetNames(typeof(HairColorAppearances))];
    public List<string> CheekMakeupStyleOptions = Enumerable.Range(0, 14).Select(i => i == 0 ? "none" : i.ToString("D2")).ToList();
    public List<string> CheekMakeupColorOptions = [.. Enum.GetNames(typeof(FrecklesMakeupColorAppearances))];
    public List<string> EyeColorOptions = [.. Enum.GetNames(typeof(EyeColorAppearances))];
    public List<string> BlemishOptions = ["", "brown_02", "brown_01", "black_02", "black_01", "red_02", "red_01"];

   
    public NpvCreationDialogViewModel()
    {
    }

    public void RefreshVisibility()
    {
        PageComplete = !string.IsNullOrEmpty(DestFolderPath);
        CanSave = CurrentPage == 1 && !string.IsNullOrEmpty(DestFolderPath);
    }
}