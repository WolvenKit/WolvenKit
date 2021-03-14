using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftItemForTarget : ActionBool
	{
		private TweakDBID _itemID;

		[Ordinal(25)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemID", cr2w, this);
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

		public CraftItemForTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
