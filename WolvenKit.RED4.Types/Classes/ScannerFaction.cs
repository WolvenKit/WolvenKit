using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerFaction : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("faction")] 
		public CString Faction
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
