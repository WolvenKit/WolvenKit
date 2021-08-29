using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerSquadInfo : ScannerChunk
	{
		private CInt32 _numberOfSquadMembers;

		[Ordinal(0)] 
		[RED("numberOfSquadMembers")] 
		public CInt32 NumberOfSquadMembers
		{
			get => GetProperty(ref _numberOfSquadMembers);
			set => SetProperty(ref _numberOfSquadMembers, value);
		}
	}
}
