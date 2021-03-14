using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootSlotSingleAppearance : gameLootSlotSingleItem
	{
		private CName _lootAppearance;

		[Ordinal(54)] 
		[RED("lootAppearance")] 
		public CName LootAppearance
		{
			get
			{
				if (_lootAppearance == null)
				{
					_lootAppearance = (CName) CR2WTypeManager.Create("CName", "lootAppearance", cr2w, this);
				}
				return _lootAppearance;
			}
			set
			{
				if (_lootAppearance == value)
				{
					return;
				}
				_lootAppearance = value;
				PropertySet(this);
			}
		}

		public gameLootSlotSingleAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
