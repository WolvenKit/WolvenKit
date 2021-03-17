using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCReference : CVariable
	{
		private NodeRef _communitySpawner;
		private CName _entryName;

		[Ordinal(0)] 
		[RED("communitySpawner")] 
		public NodeRef CommunitySpawner
		{
			get => GetProperty(ref _communitySpawner);
			set => SetProperty(ref _communitySpawner, value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		public NPCReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
