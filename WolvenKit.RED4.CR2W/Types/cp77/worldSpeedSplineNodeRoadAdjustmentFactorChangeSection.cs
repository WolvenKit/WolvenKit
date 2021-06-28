using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeRoadAdjustmentFactorChangeSection : CVariable
	{
		private CFloat _pos;
		private CFloat _targetFactor;

		[Ordinal(0)] 
		[RED("pos")] 
		public CFloat Pos
		{
			get => GetProperty(ref _pos);
			set => SetProperty(ref _pos, value);
		}

		[Ordinal(1)] 
		[RED("targetFactor")] 
		public CFloat TargetFactor
		{
			get => GetProperty(ref _targetFactor);
			set => SetProperty(ref _targetFactor, value);
		}

		public worldSpeedSplineNodeRoadAdjustmentFactorChangeSection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
