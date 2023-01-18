using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendSingleScreenShotData : ISerializable
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<rendScreenshotMode> Mode
		{
			get => GetPropertyValue<CEnum<rendScreenshotMode>>();
			set => SetPropertyValue<CEnum<rendScreenshotMode>>(value);
		}

		[Ordinal(1)] 
		[RED("outputPath")] 
		public AbsolutePathSerializable OutputPath
		{
			get => GetPropertyValue<AbsolutePathSerializable>();
			set => SetPropertyValue<AbsolutePathSerializable>(value);
		}

		[Ordinal(2)] 
		[RED("resolution")] 
		public CEnum<renddimEPreset> Resolution
		{
			get => GetPropertyValue<CEnum<renddimEPreset>>();
			set => SetPropertyValue<CEnum<renddimEPreset>>(value);
		}

		[Ordinal(3)] 
		[RED("resolutionMultiplier")] 
		public CEnum<rendResolutionMultiplier> ResolutionMultiplier
		{
			get => GetPropertyValue<CEnum<rendResolutionMultiplier>>();
			set => SetPropertyValue<CEnum<rendResolutionMultiplier>>(value);
		}

		[Ordinal(4)] 
		[RED("emmModes")] 
		public CArray<CEnum<EEnvManagerModifier>> EmmModes
		{
			get => GetPropertyValue<CArray<CEnum<EEnvManagerModifier>>>();
			set => SetPropertyValue<CArray<CEnum<EEnvManagerModifier>>>(value);
		}

		[Ordinal(5)] 
		[RED("forceLOD0")] 
		public CBool ForceLOD0
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("saveFormat")] 
		public CEnum<ESaveFormat> SaveFormat
		{
			get => GetPropertyValue<CEnum<ESaveFormat>>();
			set => SetPropertyValue<CEnum<ESaveFormat>>(value);
		}

		public rendSingleScreenShotData()
		{
			OutputPath = new();
			Resolution = Enums.renddimEPreset._1920x1080;
			ResolutionMultiplier = Enums.rendResolutionMultiplier.X2;
			EmmModes = new();
			SaveFormat = Enums.ESaveFormat.SF_PNG;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
