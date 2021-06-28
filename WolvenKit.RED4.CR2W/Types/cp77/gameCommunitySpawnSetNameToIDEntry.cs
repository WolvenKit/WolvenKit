using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCommunitySpawnSetNameToIDEntry : CVariable
	{
		private gameCommunityID _communityId;
		private CName _nameReference;

		[Ordinal(0)] 
		[RED("communityId")] 
		public gameCommunityID CommunityId
		{
			get => GetProperty(ref _communityId);
			set => SetProperty(ref _communityId, value);
		}

		[Ordinal(1)] 
		[RED("nameReference")] 
		public CName NameReference
		{
			get => GetProperty(ref _nameReference);
			set => SetProperty(ref _nameReference, value);
		}

		public gameCommunitySpawnSetNameToIDEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
