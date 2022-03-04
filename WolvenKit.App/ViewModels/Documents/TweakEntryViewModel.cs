using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;
using WinCopies.Collections.DotNetFix;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Types;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public abstract class TweakEntryViewModel : ReactiveObject
    {
        public string Name { get; set; }

        public abstract string DisplayString { get; }
        public abstract string DisplayType { get; }

        public bool IsSelected { get; set; }
    }

    public sealed class GroupViewModel : TweakEntryViewModel
    {
        private readonly Record _value;

        public GroupViewModel(string name, Record value)
        {
            Name = name;
            _value = value;

            Members = new ObservableCollection<FlatViewModel>(_value.Members
                .Select(f => new FlatViewModel(f.Key, f.Value)
                {
                    GroupName = Name
                }));

        }

        public ObservableCollection<FlatViewModel> Members { get; set; }

        public override string DisplayString => _value.ToString();
        public override string DisplayType => _value.Type;

        public Record GetValue() => _value;
    }

    public sealed class FlatViewModel : TweakEntryViewModel
    {
        private readonly IRedType _value;

        public FlatViewModel(string name, IRedType value)
        {
            Name = name;
            _value = value;

            if (value is IRedArray array)
            {
                Members = new ObservableCollection<FlatViewModel>(array
                    .OfType<IRedType>()
                    .Select(f => new FlatViewModel(RedReflection.GetRedTypeFromCSType(f.GetType()), f)
                    {
                        ArrayName = Name
                    }));
            }

        }

        public ObservableCollection<FlatViewModel> Members { get; set; } = new();


        public override string DisplayString => _value.ToString();
        public override string DisplayType => RedReflection.GetRedTypeFromCSType(_value.GetType());

        public bool IsArray => _value is IRedArray array;

        public IRedType GetValue() => _value;

        public string GroupName { get; set; }
        public string ArrayName { get; set; }
    }
}
