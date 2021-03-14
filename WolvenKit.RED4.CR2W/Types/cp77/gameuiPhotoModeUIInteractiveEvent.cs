using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeUIInteractiveEvent : redEvent
	{
		private CBool _interactive;

		[Ordinal(0)] 
		[RED("interactive")] 
		public CBool Interactive
		{
			get
			{
				if (_interactive == null)
				{
					_interactive = (CBool) CR2WTypeManager.Create("Bool", "interactive", cr2w, this);
				}
				return _interactive;
			}
			set
			{
				if (_interactive == value)
				{
					return;
				}
				_interactive = value;
				PropertySet(this);
			}
		}

		public gameuiPhotoModeUIInteractiveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
