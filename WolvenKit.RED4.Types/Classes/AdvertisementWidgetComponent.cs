using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdvertisementWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(10)] 
		[RED("format")] 
		public CEnum<AdvertisementFormat> Format
		{
			get => GetPropertyValue<CEnum<AdvertisementFormat>>();
			set => SetPropertyValue<CEnum<AdvertisementFormat>>(value);
		}

		[Ordinal(11)] 
		[RED("adGroupTDBID")] 
		public TweakDBID AdGroupTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(12)] 
		[RED("enableOverride")] 
		public CBool EnableOverride
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("adOverrideTDBID")] 
		public TweakDBID AdOverrideTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(14)] 
		[RED("adVersion")] 
		public CUInt32 AdVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("useOnlyAttachedLights")] 
		public CBool UseOnlyAttachedLights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AdvertisementWidgetComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			TintColor = new();
			ScreenAreaMultiplier = 1.000000F;
			IsEnabled = true;
		}
	}
}
