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
			get
			{
				if (_immovableAfterDrop == null)
				{
					_immovableAfterDrop = (CBool) CR2WTypeManager.Create("Bool", "immovableAfterDrop", cr2w, this);
				}
				return _immovableAfterDrop;
			}
			set
			{
				if (_immovableAfterDrop == value)
				{
					return;
				}
				_immovableAfterDrop = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("dropChance")] 
		public CFloat DropChance
		{
			get
			{
				if (_dropChance == null)
				{
					_dropChance = (CFloat) CR2WTypeManager.Create("Float", "dropChance", cr2w, this);
				}
				return _dropChance;
			}
			set
			{
				if (_dropChance == value)
				{
					return;
				}
				_dropChance = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("lootState")] 
		public CEnum<gameLootSlotState> LootState
		{
			get
			{
				if (_lootState == null)
				{
					_lootState = (CEnum<gameLootSlotState>) CR2WTypeManager.Create("gameLootSlotState", "lootState", cr2w, this);
				}
				return _lootState;
			}
			set
			{
				if (_lootState == value)
				{
					return;
				}
				_lootState = value;
				PropertySet(this);
			}
		}

		public gameLootSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
