using ReactiveUI;
using WolvenKit.RED4.TweakDB.Serialization;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class TweakEntryViewModel : ReactiveObject
    {
        public string Name { get; set; }

        public abstract string DisplayString { get; }
        public abstract string DisplayType { get; }
    }

    public sealed class GroupViewModel : TweakEntryViewModel
    {
        private readonly TweakRecord _value;

        public GroupViewModel(string name, TweakRecord value)
        {
            Name = name;
            _value = value;
        }


        public override string DisplayString => _value.ToString();
        public override string DisplayType => _value.Type;

        public TweakRecord GetValue() => _value;
    }

    public sealed class FlatViewModel : TweakEntryViewModel
    {
        private readonly IType _value;

        public FlatViewModel(string name, IType value)
        {
            Name = name;
            _value = value;
        }

        public override string DisplayString => _value.ToString();
        public override string DisplayType => _value.Name;

        public IType GetValue() => _value;
    }
}
