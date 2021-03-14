using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealDevicesGridOnEntityEvent : redEvent
	{
		private CBool _shouldDraw;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get
			{
				if (_shouldDraw == null)
				{
					_shouldDraw = (CBool) CR2WTypeManager.Create("Bool", "shouldDraw", cr2w, this);
				}
				return _shouldDraw;
			}
			set
			{
				if (_shouldDraw == value)
				{
					return;
				}
				_shouldDraw = value;
				PropertySet(this);
			}
		}

		public RevealDevicesGridOnEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
