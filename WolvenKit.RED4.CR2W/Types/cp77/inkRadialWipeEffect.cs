using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRadialWipeEffect : inkIEffect
	{
		private CFloat _startAngle;
		private CFloat _transition;

		[Ordinal(2)] 
		[RED("startAngle")] 
		public CFloat StartAngle
		{
			get => GetProperty(ref _startAngle);
			set => SetProperty(ref _startAngle, value);
		}

		[Ordinal(3)] 
		[RED("transition")] 
		public CFloat Transition
		{
			get => GetProperty(ref _transition);
			set => SetProperty(ref _transition, value);
		}

		public inkRadialWipeEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
