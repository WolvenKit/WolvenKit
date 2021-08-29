using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCookedGpsMappinData : RedBaseClass
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
	}
}
