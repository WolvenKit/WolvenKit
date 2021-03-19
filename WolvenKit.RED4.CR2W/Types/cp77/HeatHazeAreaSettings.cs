using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HeatHazeAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _effectStrength;
		private curveData<CFloat> _startDistance;
		private curveData<CFloat> _maxDistance;
		private curveData<CFloat> _patternScale;
		private curveData<CFloat> _movementSpeedScale;

		[Ordinal(2)] 
		[RED("effectStrength")] 
		public curveData<CFloat> EffectStrength
		{
			get => GetProperty(ref _effectStrength);
			set => SetProperty(ref _effectStrength, value);
		}

		[Ordinal(3)] 
		[RED("startDistance")] 
		public curveData<CFloat> StartDistance
		{
			get => GetProperty(ref _startDistance);
			set => SetProperty(ref _startDistance, value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public curveData<CFloat> MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(5)] 
		[RED("patternScale")] 
		public curveData<CFloat> PatternScale
		{
			get => GetProperty(ref _patternScale);
			set => SetProperty(ref _patternScale, value);
		}

		[Ordinal(6)] 
		[RED("movementSpeedScale")] 
		public curveData<CFloat> MovementSpeedScale
		{
			get => GetProperty(ref _movementSpeedScale);
			set => SetProperty(ref _movementSpeedScale, value);
		}

		public HeatHazeAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
