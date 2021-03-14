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
			get
			{
				if (_lootID == null)
				{
					_lootID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lootID", cr2w, this);
				}
				return _lootID;
			}
			set
			{
				if (_lootID == value)
				{
					return;
				}
				_lootID = value;
				PropertySet(this);
			}
		}

		public gameFlattenedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
