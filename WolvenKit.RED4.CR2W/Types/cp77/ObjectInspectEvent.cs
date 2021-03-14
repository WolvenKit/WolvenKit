using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectInspectEvent : redEvent
	{
		private CBool _showItem;

		[Ordinal(0)] 
		[RED("showItem")] 
		public CBool ShowItem
		{
			get
			{
				if (_showItem == null)
				{
					_showItem = (CBool) CR2WTypeManager.Create("Bool", "showItem", cr2w, this);
				}
				return _showItem;
			}
			set
			{
				if (_showItem == value)
				{
					return;
				}
				_showItem = value;
				PropertySet(this);
			}
		}

		public ObjectInspectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
