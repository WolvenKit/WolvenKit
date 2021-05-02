using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedPointOfInterestMappinData : CVariable
	{
		private CUInt32 _journalPathHash;
		private entEntityID _entityID;
		private Vector3 _position;

		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetProperty(ref _journalPathHash);
			set => SetProperty(ref _journalPathHash, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		public gameCookedPointOfInterestMappinData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
