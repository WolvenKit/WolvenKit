using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAvailableExposureMethodResult : CVariable
	{
		private CFloat _distanceToTarget;
		private CEnum<AICoverExposureMethod> _method;

		[Ordinal(0)] 
		[RED("distanceToTarget")] 
		public CFloat DistanceToTarget
		{
			get => GetProperty(ref _distanceToTarget);
			set => SetProperty(ref _distanceToTarget, value);
		}

		[Ordinal(1)] 
		[RED("method")] 
		public CEnum<AICoverExposureMethod> Method
		{
			get => GetProperty(ref _method);
			set => SetProperty(ref _method, value);
		}

		public gameAvailableExposureMethodResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
