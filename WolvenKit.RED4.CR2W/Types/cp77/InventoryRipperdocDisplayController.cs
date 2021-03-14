using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryRipperdocDisplayController : InventoryItemDisplayController
	{
		private inkWidgetReference _ownedBackground;
		private inkWidgetReference _ownedSign;

		[Ordinal(78)] 
		[RED("ownedBackground")] 
		public inkWidgetReference OwnedBackground
		{
			get
			{
				if (_ownedBackground == null)
				{
					_ownedBackground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ownedBackground", cr2w, this);
				}
				return _ownedBackground;
			}
			set
			{
				if (_ownedBackground == value)
				{
					return;
				}
				_ownedBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("ownedSign")] 
		public inkWidgetReference OwnedSign
		{
			get
			{
				if (_ownedSign == null)
				{
					_ownedSign = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ownedSign", cr2w, this);
				}
				return _ownedSign;
			}
			set
			{
				if (_ownedSign == value)
				{
					return;
				}
				_ownedSign = value;
				PropertySet(this);
			}
		}

		public InventoryRipperdocDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
