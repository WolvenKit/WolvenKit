using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSquadInfo : ScannerChunk
	{
		private CInt32 _numberOfSquadMembers;

		[Ordinal(0)] 
		[RED("numberOfSquadMembers")] 
		public CInt32 NumberOfSquadMembers
		{
			get => GetProperty(ref _numberOfSquadMembers);
			set => SetProperty(ref _numberOfSquadMembers, value);
		}

		public ScannerSquadInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
