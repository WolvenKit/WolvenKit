using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentInitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("eqManipulationVarName")] 
		public CName EqManipulationVarName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public EquipmentInitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
