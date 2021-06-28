using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UiRadialContextEvents : InputContextTransitionEvents
	{
		private Vector4 _mouse;

		[Ordinal(0)] 
		[RED("mouse")] 
		public Vector4 Mouse
		{
			get => GetProperty(ref _mouse);
			set => SetProperty(ref _mouse, value);
		}

		public UiRadialContextEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
