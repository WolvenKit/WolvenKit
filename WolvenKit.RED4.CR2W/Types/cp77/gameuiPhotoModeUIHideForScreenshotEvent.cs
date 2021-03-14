using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeUIHideForScreenshotEvent : redEvent
	{
		private CBool _hide;

		[Ordinal(0)] 
		[RED("hide")] 
		public CBool Hide
		{
			get
			{
				if (_hide == null)
				{
					_hide = (CBool) CR2WTypeManager.Create("Bool", "hide", cr2w, this);
				}
				return _hide;
			}
			set
			{
				if (_hide == value)
				{
					return;
				}
				_hide = value;
				PropertySet(this);
			}
		}

		public gameuiPhotoModeUIHideForScreenshotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
