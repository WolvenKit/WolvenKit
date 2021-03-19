using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HACK_AREA_Settings : IAreaSettings
	{
		private CFloat _surfelScale;
		private CFloat _missingEnergyScale;
		private CBool _overrideOnPureView;
		private CFloat _surfAlbedoOverrideRatio;
		private HDRColor _surfAlbedoOverride;
		private CFloat _skyScale;
		private curveData<HDRColor> _bottomHemisphereTint;
		private CFloat _bottomHemisphereStrength;
		private CFloat _emissiveScale;

		[Ordinal(2)] 
		[RED("surfelScale")] 
		public CFloat SurfelScale
		{
			get => GetProperty(ref _surfelScale);
			set => SetProperty(ref _surfelScale, value);
		}

		[Ordinal(3)] 
		[RED("missingEnergyScale")] 
		public CFloat MissingEnergyScale
		{
			get => GetProperty(ref _missingEnergyScale);
			set => SetProperty(ref _missingEnergyScale, value);
		}

		[Ordinal(4)] 
		[RED("overrideOnPureView")] 
		public CBool OverrideOnPureView
		{
			get => GetProperty(ref _overrideOnPureView);
			set => SetProperty(ref _overrideOnPureView, value);
		}

		[Ordinal(5)] 
		[RED("surfAlbedoOverrideRatio")] 
		public CFloat SurfAlbedoOverrideRatio
		{
			get => GetProperty(ref _surfAlbedoOverrideRatio);
			set => SetProperty(ref _surfAlbedoOverrideRatio, value);
		}

		[Ordinal(6)] 
		[RED("surfAlbedoOverride")] 
		public HDRColor SurfAlbedoOverride
		{
			get => GetProperty(ref _surfAlbedoOverride);
			set => SetProperty(ref _surfAlbedoOverride, value);
		}

		[Ordinal(7)] 
		[RED("skyScale")] 
		public CFloat SkyScale
		{
			get => GetProperty(ref _skyScale);
			set => SetProperty(ref _skyScale, value);
		}

		[Ordinal(8)] 
		[RED("bottomHemisphereTint")] 
		public curveData<HDRColor> BottomHemisphereTint
		{
			get => GetProperty(ref _bottomHemisphereTint);
			set => SetProperty(ref _bottomHemisphereTint, value);
		}

		[Ordinal(9)] 
		[RED("bottomHemisphereStrength")] 
		public CFloat BottomHemisphereStrength
		{
			get => GetProperty(ref _bottomHemisphereStrength);
			set => SetProperty(ref _bottomHemisphereStrength, value);
		}

		[Ordinal(10)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get => GetProperty(ref _emissiveScale);
			set => SetProperty(ref _emissiveScale, value);
		}

		public HACK_AREA_Settings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
