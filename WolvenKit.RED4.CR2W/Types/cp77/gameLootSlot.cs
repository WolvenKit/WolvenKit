using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootSlot : gameLootContainerBase
	{
		private CBool _immovableAfterDrop;
		private CFloat _dropChance;
		private CEnum<gameLootSlotState> _lootState;

		[Ordinal(50)] 
		[RED("immovableAfterDrop")] 
		public CBool ImmovableAfterDrop
		{
			get => GetProperty(ref _immovableAfterDrop);
			set => SetProperty(ref _immovableAfterDrop, value);
		}

		[Ordinal(51)] 
		[RED("dropChance")] 
		public CFloat DropChance
		{
			get => GetProperty(ref _dropChance);
			set => SetProperty(ref _dropChance, value);
		}

		[Ordinal(52)] 
		[RED("lootState")] 
		public CEnum<gameLootSlotState> LootState
		{
			get => GetProperty(ref _lootState);
			set => SetProperty(ref _lootState, value);
		}

		public gameLootSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
