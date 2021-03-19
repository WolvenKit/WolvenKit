using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCommunityTemplate_NodeType : questSpawnManagerNodeType
	{
		private NodeRef _spawnerReference;
		private CName _communityEntryName;
		private CName _communityEntryPhaseName;

		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetProperty(ref _spawnerReference);
			set => SetProperty(ref _spawnerReference, value);
		}

		[Ordinal(2)] 
		[RED("communityEntryName")] 
		public CName CommunityEntryName
		{
			get => GetProperty(ref _communityEntryName);
			set => SetProperty(ref _communityEntryName, value);
		}

		[Ordinal(3)] 
		[RED("communityEntryPhaseName")] 
		public CName CommunityEntryPhaseName
		{
			get => GetProperty(ref _communityEntryPhaseName);
			set => SetProperty(ref _communityEntryPhaseName, value);
		}

		public questCommunityTemplate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
