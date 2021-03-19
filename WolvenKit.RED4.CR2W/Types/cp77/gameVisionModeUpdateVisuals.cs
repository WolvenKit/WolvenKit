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
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		public gameVisionModeUpdateVisuals(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
