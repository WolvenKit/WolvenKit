using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdvertisementWidgetComponent : IWorldWidgetComponent
	{
		private CEnum<AdvertisementFormat> _format;
		private TweakDBID _adGroupTDBID;
		private CBool _enableOverride;
		private TweakDBID _adOverrideTDBID;
		private CUInt32 _adVersion;
		private CBool _useOnlyAttachedLights;

		[Ordinal(10)] 
		[RED("format")] 
		public CEnum<AdvertisementFormat> Format
		{
			get => GetProperty(ref _format);
			set => SetProperty(ref _format, value);
		}

		[Ordinal(11)] 
		[RED("adGroupTDBID")] 
		public TweakDBID AdGroupTDBID
		{
			get => GetProperty(ref _adGroupTDBID);
			set => SetProperty(ref _adGroupTDBID, value);
		}

		[Ordinal(12)] 
		[RED("enableOverride")] 
		public CBool EnableOverride
		{
			get => GetProperty(ref _enableOverride);
			set => SetProperty(ref _enableOverride, value);
		}

		[Ordinal(13)] 
		[RED("adOverrideTDBID")] 
		public TweakDBID AdOverrideTDBID
		{
			get => GetProperty(ref _adOverrideTDBID);
			set => SetProperty(ref _adOverrideTDBID, value);
		}

		[Ordinal(14)] 
		[RED("adVersion")] 
		public CUInt32 AdVersion
		{
			get => GetProperty(ref _adVersion);
			set => SetProperty(ref _adVersion, value);
		}

		[Ordinal(15)] 
		[RED("useOnlyAttachedLights")] 
		public CBool UseOnlyAttachedLights
		{
			get => GetProperty(ref _useOnlyAttachedLights);
			set => SetProperty(ref _useOnlyAttachedLights, value);
		}
	}
}
