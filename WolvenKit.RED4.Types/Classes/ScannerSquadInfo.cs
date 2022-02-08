using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerSquadInfo : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("numberOfSquadMembers")] 
		public CInt32 NumberOfSquadMembers
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
