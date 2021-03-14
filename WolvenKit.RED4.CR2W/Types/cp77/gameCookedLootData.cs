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
			get
			{
				if (_lootTables == null)
				{
					_lootTables = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "lootTables", cr2w, this);
				}
				return _lootTables;
			}
			set
			{
				if (_lootTables == value)
				{
					return;
				}
				_lootTables = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get
			{
				if (_contentAssignment == null)
				{
					_contentAssignment = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "contentAssignment", cr2w, this);
				}
				return _contentAssignment;
			}
			set
			{
				if (_contentAssignment == value)
				{
					return;
				}
				_contentAssignment = value;
				PropertySet(this);
			}
		}

		public gameCookedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
