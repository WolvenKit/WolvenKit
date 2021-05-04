using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedLootData : ISerializable
	{
		private CArray<TweakDBID> _lootTables;
		private TweakDBID _contentAssignment;

		[Ordinal(0)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get => GetProperty(ref _lootTables);
			set => SetProperty(ref _lootTables, value);
		}

		[Ordinal(1)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get => GetProperty(ref _contentAssignment);
			set => SetProperty(ref _contentAssignment, value);
		}

		public gameCookedLootData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
