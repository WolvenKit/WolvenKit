using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAdvertisementNode : worldStaticMeshNode
	{
		[Ordinal(15)] 
		[RED("meshInitialScale")] 
		public Vector3 MeshInitialScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(16)] 
		[RED("format")] 
		public CEnum<AdvertisementFormat> Format
		{
			get => GetPropertyValue<CEnum<AdvertisementFormat>>();
			set => SetPropertyValue<CEnum<AdvertisementFormat>>(value);
		}

		[Ordinal(17)] 
		[RED("adGroupTDBID")] 
		public TweakDBID AdGroupTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(18)] 
		[RED("enableOverride")] 
		public CBool EnableOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("adOverrideTDBID")] 
		public TweakDBID AdOverrideTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(20)] 
		[RED("adVersion")] 
		public CUInt32 AdVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(21)] 
		[RED("glitchValue")] 
		public CFloat GlitchValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("lightsData")] 
		public CArray<worldAdvertisementLightData> LightsData
		{
			get => GetPropertyValue<CArray<worldAdvertisementLightData>>();
			set => SetPropertyValue<CArray<worldAdvertisementLightData>>(value);
		}

		public worldAdvertisementNode()
		{
			MeshInitialScale = new();
			LightsData = new();
		}
	}
}
