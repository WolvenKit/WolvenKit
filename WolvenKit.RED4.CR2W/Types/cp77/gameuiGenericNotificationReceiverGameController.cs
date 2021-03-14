using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationReceiverGameController : gameuiWidgetGameController
	{
		private inkEmptyCallback _itemChanged;

		[Ordinal(2)] 
		[RED("ItemChanged")] 
		public inkEmptyCallback ItemChanged
		{
			get
			{
				if (_itemChanged == null)
				{
					_itemChanged = (inkEmptyCallback) CR2WTypeManager.Create("inkEmptyCallback", "ItemChanged", cr2w, this);
				}
				return _itemChanged;
			}
			set
			{
				if (_itemChanged == value)
				{
					return;
				}
				_itemChanged = value;
				PropertySet(this);
			}
		}

		public gameuiGenericNotificationReceiverGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
