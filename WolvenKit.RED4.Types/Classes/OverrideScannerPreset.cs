using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OverrideScannerPreset : redEvent
	{
		[Ordinal(0)] 
		[RED("scannerPreset")] 
		public TweakDBID ScannerPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
