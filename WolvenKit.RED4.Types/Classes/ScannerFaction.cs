using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerFaction : ScannerChunk
	{
		private CString _faction;

		[Ordinal(0)] 
		[RED("faction")] 
		public CString Faction
		{
			get => GetProperty(ref _faction);
			set => SetProperty(ref _faction, value);
		}
	}
}
