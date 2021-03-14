using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Hotkey : IScriptable
	{
		private CEnum<gameEHotkey> _hotkey;
		private gameItemID _itemID;
		private CArray<CEnum<gamedataItemType>> _scope;

		[Ordinal(0)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey_
		{
			get
			{
				if (_hotkey == null)
				{
					_hotkey = (CEnum<gameEHotkey>) CR2WTypeManager.Create("gameEHotkey", "hotkey", cr2w, this);
				}
				return _hotkey;
			}
			set
			{
				if (_hotkey == value)
				{
					return;
				}
				_hotkey = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scope")] 
		public CArray<CEnum<gamedataItemType>> Scope
		{
			get
			{
				if (_scope == null)
				{
					_scope = (CArray<CEnum<gamedataItemType>>) CR2WTypeManager.Create("array:gamedataItemType", "scope", cr2w, this);
				}
				return _scope;
			}
			set
			{
				if (_scope == value)
				{
					return;
				}
				_scope = value;
				PropertySet(this);
			}
		}

		public Hotkey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
