using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantIrradianceeSettings : IAreaSettings
	{
		private curveData<Vector2> _distantRange;
		private curveData<Vector3> _distantHeightRange;
		private curveData<CFloat> _distantLights;
		private curveData<Vector2> _distantLightsRange;
		private curveData<CFloat> _blendDistance;

		[Ordinal(2)] 
		[RED("distantRange")] 
		public curveData<Vector2> DistantRange
		{
			get => GetProperty(ref _distantRange);
			set => SetProperty(ref _distantRange, value);
		}

		[Ordinal(3)] 
		[RED("distantHeightRange")] 
		public curveData<Vector3> DistantHeightRange
		{
			get => GetProperty(ref _distantHeightRange);
			set => SetProperty(ref _distantHeightRange, value);
		}

		[Ordinal(4)] 
		[RED("distantLights")] 
		public curveData<CFloat> DistantLights
		{
			get => GetProperty(ref _distantLights);
			set => SetProperty(ref _distantLights, value);
		}

		[Ordinal(5)] 
		[RED("distantLightsRange")] 
		public curveData<Vector2> DistantLightsRange
		{
			get => GetProperty(ref _distantLightsRange);
			set => SetProperty(ref _distantLightsRange, value);
		}

		[Ordinal(6)] 
		[RED("blendDistance")] 
		public curveData<CFloat> BlendDistance
		{
			get => GetProperty(ref _blendDistance);
			set => SetProperty(ref _blendDistance, value);
		}

		public DistantIrradianceeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
