using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScanInstance : ModuleInstance
	{
		[Ordinal(6)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
