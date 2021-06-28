using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedMultiMappinData : CVariable
	{
		private CUInt32 _journalPathHash;
		private CArray<Vector3> _positions;

		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetProperty(ref _journalPathHash);
			set => SetProperty(ref _journalPathHash, value);
		}

		[Ordinal(1)] 
		[RED("positions")] 
		public CArray<Vector3> Positions
		{
			get => GetProperty(ref _positions);
			set => SetProperty(ref _positions, value);
		}

		public gameCookedMultiMappinData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
