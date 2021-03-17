using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFlattenedLootData : CVariable
	{
		private TweakDBID _lootID;

		[Ordinal(0)] 
		[RED("lootID")] 
		public TweakDBID LootID
		{
			get => GetProperty(ref _lootID);
			set => SetProperty(ref _lootID, value);
		}

		public gameFlattenedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
