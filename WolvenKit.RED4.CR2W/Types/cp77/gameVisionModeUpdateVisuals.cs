using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeUpdateVisuals : redEvent
	{
		private CBool _pulse;

		[Ordinal(0)] 
		[RED("pulse")] 
		public CBool Pulse
		{
			get
			{
				if (_pulse == null)
				{
					_pulse = (CBool) CR2WTypeManager.Create("Bool", "pulse", cr2w, this);
				}
				return _pulse;
			}
			set
			{
				if (_pulse == value)
				{
					return;
				}
				_pulse = value;
				PropertySet(this);
			}
		}

		public gameVisionModeUpdateVisuals(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
