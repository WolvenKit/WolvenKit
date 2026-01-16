using System;
using System.Windows.Media;

namespace WolvenKit.App.Helpers;

public static class TimelineColorHelper
{
    public static string GetCategoryForEventType(Type eventType)
    {
        var name = eventType.Name;

        return name switch
        {
            _ when name.Contains("DialogLine") => "Dialogue",
            _ when name.Contains("Anim") || name.Contains("Idle") => "Animation",
            _ when name.Contains("LookAt") => "LookAt",
            _ when name.Contains("Audio") => "Audio",
            _ when name.Contains("Camera") => "Camera",
            _ when name.Contains("VFX") => "VFX",
            _ when name.Contains("Gameplay") => "Gameplay",
            _ when name.Contains("Placement") || name.Contains("Pose") || name.Contains("IK") => "Placement",
            _ => "Other"
        };
    }

    public static Color GetColorForCategory(string category)
    {
        return category switch
        {
            "Dialogue" => Color.FromRgb(26, 94, 203),
            "Animation" => Color.FromRgb(25, 163, 62),
            "LookAt" => Color.FromRgb(200, 151, 4),
            "Audio" => Color.FromRgb(182, 36, 22),
            "Camera" => Color.FromRgb(154, 99, 191),
            "VFX" => Color.FromRgb(245, 106, 0),
            "Gameplay" => Color.FromRgb(0, 172, 193),
            "Placement" => Color.FromRgb(158, 158, 158),
            _ => Color.FromRgb(117, 117, 117)
        };
    }

    public static Color GetColorForEventType(Type eventType)
    {
        var name = eventType.Name;

        return name switch
        {
            "scnPlaySkAnimEvent" => Color.FromRgb(52, 168, 83),
            "scnChangeIdleAnimEvent" => Color.FromRgb(76, 175, 80),
            _ when name.Contains("Anim") => Color.FromRgb(67, 160, 71),
            "scnLookAtEvent" => Color.FromRgb(251, 188, 5),
            "scnLookAtAdvancedEvent" => Color.FromRgb(255, 202, 40),
            _ when name.Contains("LookAt") => Color.FromRgb(253, 195, 20),
            _ => GetColorForCategory(GetCategoryForEventType(eventType))
        };
    }
}
