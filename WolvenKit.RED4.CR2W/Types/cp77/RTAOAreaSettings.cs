using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RTAOAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _rangeNear;
		private curveData<CFloat> _rangeFar;
		private curveData<CFloat> _radiusNear;
		private curveData<CFloat> _radiusFar;
		private curveData<CFloat> _coneAoDiffuseStrength;
		private curveData<CFloat> _coneAoSpecularStrength;
		private curveData<CFloat> _coneAoSpecularTreshold;
		private curveData<CFloat> _lightAoDiffuseStrength;
		private curveData<CFloat> _lightAoSpecularStrength;

		[Ordinal(2)] 
		[RED("RangeNear")] 
		public curveData<CFloat> RangeNear
		{
			get => GetProperty(ref _rangeNear);
			set => SetProperty(ref _rangeNear, value);
		}

		[Ordinal(3)] 
		[RED("RangeFar")] 
		public curveData<CFloat> RangeFar
		{
			get => GetProperty(ref _rangeFar);
			set => SetProperty(ref _rangeFar, value);
		}

		[Ordinal(4)] 
		[RED("RadiusNear")] 
		public curveData<CFloat> RadiusNear
		{
			get => GetProperty(ref _radiusNear);
			set => SetProperty(ref _radiusNear, value);
		}

		[Ordinal(5)] 
		[RED("RadiusFar")] 
		public curveData<CFloat> RadiusFar
		{
			get => GetProperty(ref _radiusFar);
			set => SetProperty(ref _radiusFar, value);
		}

		[Ordinal(6)] 
		[RED("coneAoDiffuseStrength")] 
		public curveData<CFloat> ConeAoDiffuseStrength
		{
			get => GetProperty(ref _coneAoDiffuseStrength);
			set => SetProperty(ref _coneAoDiffuseStrength, value);
		}

		[Ordinal(7)] 
		[RED("coneAoSpecularStrength")] 
		public curveData<CFloat> ConeAoSpecularStrength
		{
			get => GetProperty(ref _coneAoSpecularStrength);
			set => SetProperty(ref _coneAoSpecularStrength, value);
		}

		[Ordinal(8)] 
		[RED("coneAoSpecularTreshold")] 
		public curveData<CFloat> ConeAoSpecularTreshold
		{
			get => GetProperty(ref _coneAoSpecularTreshold);
			set => SetProperty(ref _coneAoSpecularTreshold, value);
		}

		[Ordinal(9)] 
		[RED("lightAoDiffuseStrength")] 
		public curveData<CFloat> LightAoDiffuseStrength
		{
			get => GetProperty(ref _lightAoDiffuseStrength);
			set => SetProperty(ref _lightAoDiffuseStrength, value);
		}

		[Ordinal(10)] 
		[RED("lightAoSpecularStrength")] 
		public curveData<CFloat> LightAoSpecularStrength
		{
			get => GetProperty(ref _lightAoSpecularStrength);
			set => SetProperty(ref _lightAoSpecularStrength, value);
		}

		public RTAOAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
