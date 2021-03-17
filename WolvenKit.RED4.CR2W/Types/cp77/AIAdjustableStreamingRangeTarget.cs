using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAdjustableStreamingRangeTarget : gameObject
	{
		private CFloat _minStreamingDistance;

		[Ordinal(40)] 
		[RED("minStreamingDistance")] 
		public CFloat MinStreamingDistance
		{
			get => GetProperty(ref _minStreamingDistance);
			set => SetProperty(ref _minStreamingDistance, value);
		}

		public AIAdjustableStreamingRangeTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
