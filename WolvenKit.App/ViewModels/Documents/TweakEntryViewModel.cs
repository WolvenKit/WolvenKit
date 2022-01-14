using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Types;

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
        private readonly IType _value;

        public FlatViewModel(string name, IType value)
        {
            Name = name;
            _value = value;

            if (value is IArray array)
            {
                Members = new ObservableCollection<FlatViewModel>(array.GetItems()
                    .OfType<IType>()
                    .Select(f => new FlatViewModel(f.Name, f)
                    {
                        ArrayName = Name
                    }));
            }

        }

        public ObservableCollection<FlatViewModel> Members { get; set; } = new();


        public override string DisplayString => _value.ToString();
        public override string DisplayType => _value.Name;

        public bool IsArray => _value is IArray array;

        public IType GetValue() => _value;

        public string GroupName { get; set; }
        public string ArrayName { get; set; }
    }
}
