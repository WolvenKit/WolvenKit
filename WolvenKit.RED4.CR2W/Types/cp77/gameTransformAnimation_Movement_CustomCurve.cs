using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Movement_CustomCurve : gameTransformAnimation_Movement
	{
		private curveData<CFloat> _curve;

		[Ordinal(0)] 
		[RED("curve")] 
		public curveData<CFloat> Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		public gameTransformAnimation_Movement_CustomCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
