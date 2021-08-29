using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCookedLootData : ISerializable
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
	}
}
