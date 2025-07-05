using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResetNPCSensesMainPreset : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("newSensesPresetName")] 
		public CString NewSensesPresetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ResetNPCSensesMainPreset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
