using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnerNotReady_ConditionType : questISpawnerConditionType
	{
		private NodeRef _spawnerReference;
		private CArray<CName> _communityEntryNames;

		[Ordinal(0)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetProperty(ref _spawnerReference);
			set => SetProperty(ref _spawnerReference, value);
		}

		[Ordinal(1)] 
		[RED("communityEntryNames")] 
		public CArray<CName> CommunityEntryNames
		{
			get => GetProperty(ref _communityEntryNames);
			set => SetProperty(ref _communityEntryNames, value);
		}
	}
}
