using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealQuickhackMenu : HUDManagerRequest
	{
		private CBool _shouldOpenWheel;

		[Ordinal(1)] 
		[RED("shouldOpenWheel")] 
		public CBool ShouldOpenWheel
		{
			get
			{
				if (_shouldOpenWheel == null)
				{
					_shouldOpenWheel = (CBool) CR2WTypeManager.Create("Bool", "shouldOpenWheel", cr2w, this);
				}
				return _shouldOpenWheel;
			}
			set
			{
				if (_shouldOpenWheel == value)
				{
					return;
				}
				_shouldOpenWheel = value;
				PropertySet(this);
			}
		}

		public RevealQuickhackMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
