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
			get => GetProperty(ref _lootAppearance);
			set => SetProperty(ref _lootAppearance, value);
		}

		public gameLootSlotSingleAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
