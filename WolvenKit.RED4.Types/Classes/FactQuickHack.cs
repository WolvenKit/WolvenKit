using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FactQuickHack : ActionBool
	{
		private ComputerQuickHackData _factProperties;

		[Ordinal(25)] 
		[RED("factProperties")] 
		public ComputerQuickHackData FactProperties
		{
			get => GetProperty(ref _factProperties);
			set => SetProperty(ref _factProperties, value);
		}
	}
}
