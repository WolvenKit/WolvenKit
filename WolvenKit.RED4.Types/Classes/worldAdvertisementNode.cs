using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAdvertisementNode : worldStaticMeshNode
	{
		private Vector3 _meshInitialScale;
		private CEnum<AdvertisementFormat> _format;
		private TweakDBID _adGroupTDBID;
		private CBool _enableOverride;
		private TweakDBID _adOverrideTDBID;
		private CUInt32 _adVersion;
		private CFloat _glitchValue;
		private CArray<worldAdvertisementLightData> _lightsData;

		[Ordinal(15)] 
		[RED("meshInitialScale")] 
		public Vector3 MeshInitialScale
		{
			get => GetProperty(ref _meshInitialScale);
			set => SetProperty(ref _meshInitialScale, value);
		}

		[Ordinal(16)] 
		[RED("format")] 
		public CEnum<AdvertisementFormat> Format
		{
			get => GetProperty(ref _format);
			set => SetProperty(ref _format, value);
		}

		[Ordinal(17)] 
		[RED("adGroupTDBID")] 
		public TweakDBID AdGroupTDBID
		{
			get => GetProperty(ref _adGroupTDBID);
			set => SetProperty(ref _adGroupTDBID, value);
		}

		[Ordinal(18)] 
		[RED("enableOverride")] 
		public CBool EnableOverride
		{
			get => GetProperty(ref _enableOverride);
			set => SetProperty(ref _enableOverride, value);
		}

		[Ordinal(19)] 
		[RED("adOverrideTDBID")] 
		public TweakDBID AdOverrideTDBID
		{
			get => GetProperty(ref _adOverrideTDBID);
			set => SetProperty(ref _adOverrideTDBID, value);
		}

		[Ordinal(20)] 
		[RED("adVersion")] 
		public CUInt32 AdVersion
		{
			get => GetProperty(ref _adVersion);
			set => SetProperty(ref _adVersion, value);
		}

		[Ordinal(21)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get => GetProperty(ref _glitchValue);
			set => SetProperty(ref _glitchValue, value);
		}

		[Ordinal(22)] 
		[RED("lightsData")] 
		public CArray<worldAdvertisementLightData> LightsData
		{
			get => GetProperty(ref _lightsData);
			set => SetProperty(ref _lightsData, value);
		}
	}
}
