using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		private wCHandle<gameItemObject> _itemObject;

		[Ordinal(1)] 
		[RED("itemObject")] 
		public wCHandle<gameItemObject> ItemObject
		{
			get
			{
				if (_itemObject == null)
				{
					_itemObject = (wCHandle<gameItemObject>) CR2WTypeManager.Create("whandle:gameItemObject", "itemObject", cr2w, this);
				}
				return _itemObject;
			}
			set
			{
				if (_itemObject == value)
				{
					return;
				}
				_itemObject = value;
				PropertySet(this);
			}
		}

		public ThrowEquipmentRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
