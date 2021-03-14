using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ManagePersonalLinkChangeEvent : redEvent
	{
		private CBool _shouldEquip;

		[Ordinal(0)] 
		[RED("shouldEquip")] 
		public CBool ShouldEquip
		{
			get
			{
				if (_shouldEquip == null)
				{
					_shouldEquip = (CBool) CR2WTypeManager.Create("Bool", "shouldEquip", cr2w, this);
				}
				return _shouldEquip;
			}
			set
			{
				if (_shouldEquip == value)
				{
					return;
				}
				_shouldEquip = value;
				PropertySet(this);
			}
		}

		public ManagePersonalLinkChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
