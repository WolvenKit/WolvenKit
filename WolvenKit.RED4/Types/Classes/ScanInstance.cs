using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScanInstance : ModuleInstance
	{
		[Ordinal(6)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScanInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
