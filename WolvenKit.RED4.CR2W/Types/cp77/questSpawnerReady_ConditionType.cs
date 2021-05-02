using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnerReady_ConditionType : questISpawnerConditionType
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

		public questSpawnerReady_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
