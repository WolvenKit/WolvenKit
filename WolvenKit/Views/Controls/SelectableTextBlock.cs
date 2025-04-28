using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace WolvenKit.Views.Controls;

internal static class TextEditorWrapper
{
    // Internal TextEditor type
    private static readonly Type TextEditorType =
        Type.GetType(
            "System.Windows.Documents.TextEditor, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
            throwOnError: true
        );

    // TextEditor.RegisterCommandHandlers(Type, bool, bool, bool)
    private static readonly MethodInfo RegisterCmdHandlersMethod =
        TextEditorType.GetMethod(
            "RegisterCommandHandlers",
            BindingFlags.Static | BindingFlags.NonPublic,
            null,
            new[] { typeof(Type), typeof(bool), typeof(bool), typeof(bool) },
            null
        );                                              

    // TextBlock’s private ITextContainer property
    private static readonly PropertyInfo TextContainerProperty =
        typeof(TextBlock).GetProperty(
            "TextContainer",
            BindingFlags.Instance | BindingFlags.NonPublic
        );                                                                      

    // ITextContainer.TextView property
    private static readonly Type TextContainerType =
        Type.GetType(
            "System.Windows.Documents.ITextContainer, PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35",
            throwOnError: true
        );                                                                  

    private static readonly PropertyInfo TextContainerTextViewProp =
        TextContainerType.GetProperty("TextView");               

    // TextEditor’s TextView and IsReadOnly instance properties
    private static readonly PropertyInfo TextViewProp =
        TextEditorType.GetProperty("TextView", BindingFlags.Instance | BindingFlags.NonPublic);

    private static readonly PropertyInfo IsReadOnlyProp =
        TextEditorType.GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);

    // TextEditor’s non-public ctor: (ITextContainer, FrameworkElement, bool)
    private static readonly ConstructorInfo TextEditorCtor =
        TextEditorType.GetConstructor(
            BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            new[] { TextContainerProperty.PropertyType, typeof(FrameworkElement), typeof(bool) },
            null
        );                                                      

    /// <summary>
    /// Registers the native WPF selection commands for a control type.
    /// Call once, typically in the static constructor of your custom control.
    /// </summary>
    public static void RegisterCommandHandlers(Type controlType)
    {
        RegisterCmdHandlersMethod.Invoke(
            null,
            new object[] { controlType, /* acceptsRichContent */ true, /* readOnly */ true, /* registerEventListeners */ true }
        );                                                     
    }

    /// <summary>
    /// Attaches a TextEditor instance to a TextBlock for native selection.
    /// Call this in your control’s instance constructor.
    /// </summary>
    public static void Attach(TextBlock tb)
    {
        // Obtain private ITextContainer
        var textContainer = TextContainerProperty.GetValue(tb);      

        // Create the TextEditor (isUndoEnabled: false)
        var editor = TextEditorCtor.Invoke(new[] { textContainer, tb, false });

        // Mark it read-only
        IsReadOnlyProp.SetValue(editor, true);                        

        // Link the view so rendering and hit-testing align
        TextViewProp.SetValue(editor, TextContainerTextViewProp.GetValue(textContainer));
    }
}

public class SelectableTextBlock : TextBlock
{
    static SelectableTextBlock()
    {
        // Allow keyboard focus so selection keys work
        FocusableProperty.OverrideMetadata(
            typeof(SelectableTextBlock),
            new FrameworkPropertyMetadata(true)
        );                                                                       

        // Remove default focus rectangle
        FocusVisualStyleProperty.OverrideMetadata(
            typeof(SelectableTextBlock),
            new FrameworkPropertyMetadata((Style)null)
        );                                                                           

        // Register native selection command handlers
        TextEditorWrapper.RegisterCommandHandlers(typeof(SelectableTextBlock));      
    }

    public SelectableTextBlock()
    {
        // Hit-test on transparent areas
        Background = Brushes.Transparent;

        // Show I-beam cursor to signal selection capability
        Cursor = Cursors.IBeam;

        // Attach the native TextEditor
        TextEditorWrapper.Attach(this);
    }
}