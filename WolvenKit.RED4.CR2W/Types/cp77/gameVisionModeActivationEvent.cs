using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeActivationEvent : redEvent
	{
		private CBool _activate;

		[Ordinal(0)] 
		[RED("activate")] 
		public CBool Activate
		{
			get
			{
				if (_activate == null)
				{
					_activate = (CBool) CR2WTypeManager.Create("Bool", "activate", cr2w, this);
				}
				return _activate;
			}
			set
			{
				if (_activate == value)
				{
					return;
				}
				_activate = value;
				PropertySet(this);
			}
		}

		public gameVisionModeActivationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
