using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCReference : RedBaseClass
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
	}
}
