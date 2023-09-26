using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetNPCSensesMainPreset : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("newSensesPresetName")] 
		public CString NewSensesPresetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SetNPCSensesMainPreset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
