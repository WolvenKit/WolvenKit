using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactQuickHack : ActionBool
	{
		[Ordinal(38)] 
		[RED("factProperties")] 
		public ComputerQuickHackData FactProperties
		{
			get => GetPropertyValue<ComputerQuickHackData>();
			set => SetPropertyValue<ComputerQuickHackData>(value);
		}

		public FactQuickHack()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
