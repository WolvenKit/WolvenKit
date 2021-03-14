using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsToggleAimDownSightsEvent : redEvent
	{
		private CBool _toggleOn;

		[Ordinal(0)] 
		[RED("toggleOn")] 
		public CBool ToggleOn
		{
			get
			{
				if (_toggleOn == null)
				{
					_toggleOn = (CBool) CR2WTypeManager.Create("Bool", "toggleOn", cr2w, this);
				}
				return _toggleOn;
			}
			set
			{
				if (_toggleOn == value)
				{
					return;
				}
				_toggleOn = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsToggleAimDownSightsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
