using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastForwardAvailableEvents : ScenesFastForwardTransition
	{
		private CBool _forceCloseFX;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("forceCloseFX")] 
		public CBool ForceCloseFX
		{
			get => GetProperty(ref _forceCloseFX);
			set => SetProperty(ref _forceCloseFX, value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		public FastForwardAvailableEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
