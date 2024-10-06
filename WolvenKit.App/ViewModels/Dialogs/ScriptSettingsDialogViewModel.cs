using System;
using System.Collections.Generic;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ScriptSettingsDialogViewModel : DialogViewModel
{
    [ObservableProperty]
    private ScriptFile _scriptFile;

    [ObservableProperty]
    private SettingsTypeDescriptor _settings;

    public ScriptSettingsDialogViewModel(ScriptFile scriptFile)
    {
        _scriptFile = scriptFile;
        _settings = new SettingsTypeDescriptor(scriptFile.Settings);
    }

    [RelayCommand]
    private void Ok() => DialogHandler?.Invoke(this);

    [RelayCommand]
    private void Cancel() => DialogHandler?.Invoke(this);

    public class SettingsTypeDescriptor : ICustomTypeDescriptor
    {
        public Dictionary<string, SettingsEntry> Settings;

        public SettingsTypeDescriptor(Dictionary<string, SettingsEntry> settingsPreset)
        {
            Settings = settingsPreset;
        }

        public AttributeCollection GetAttributes() => TypeDescriptor.GetAttributes(this, true);

        public string? GetClassName() => TypeDescriptor.GetClassName(this, true);

        public string? GetComponentName() => TypeDescriptor.GetComponentName(this, true);

        public TypeConverter GetConverter() => TypeDescriptor.GetConverter(this, true);

        public EventDescriptor? GetDefaultEvent() => TypeDescriptor.GetDefaultEvent(this, true);

        public PropertyDescriptor? GetDefaultProperty() => TypeDescriptor.GetDefaultProperty(this, true);

        public object? GetEditor(Type editorBaseType) => TypeDescriptor.GetEditor(this, editorBaseType, true);

        public EventDescriptorCollection GetEvents() => TypeDescriptor.GetEvents(this, true);

        public EventDescriptorCollection GetEvents(Attribute[]? attributes) => TypeDescriptor.GetEvents(this, attributes, true);

        public PropertyDescriptorCollection GetProperties()
        {
            var modelProperties = new List<SettingsPropertyDescriptor>();
            foreach (var (_, entry) in Settings)
            {
                modelProperties.Add(new SettingsPropertyDescriptor(this, entry.Name, entry.Type, []));
            }

            return new PropertyDescriptorCollection(modelProperties.ToArray());
        }

        public PropertyDescriptorCollection GetProperties(Attribute[]? attributes) => TypeDescriptor.GetProperties(this, attributes, true);

        public object? GetPropertyOwner(PropertyDescriptor? pd) => pd != null ? this : null;
    }

    public class SettingsPropertyDescriptor : PropertyDescriptor
    {
        private readonly SettingsTypeDescriptor _typeDescriptor;

        public override Type ComponentType { get; } = typeof(SettingsTypeDescriptor);
        public override bool IsReadOnly { get; } = false;
        public override Type PropertyType { get; }

        public override string DisplayName => Name;

        public SettingsPropertyDescriptor(SettingsTypeDescriptor typeDescriptor, string name, Type propertyType, Attribute[]? attrs) : base(name, attrs)
        {
            _typeDescriptor = typeDescriptor;
            PropertyType = propertyType;
        }

        public override bool CanResetValue(object component) => true;

        public override object? GetValue(object? component) => _typeDescriptor.Settings[Name].Value;

        public override void ResetValue(object component)
        {
        }

        public override void SetValue(object? component, object? value) => _typeDescriptor.Settings[Name].Value = value;

        public override bool ShouldSerializeValue(object component) => false;
    }
}