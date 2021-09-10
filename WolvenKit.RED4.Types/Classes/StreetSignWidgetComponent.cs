using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StreetSignWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(10)] 
		[RED("streetSignTDBID")] 
		public TweakDBID StreetSignTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(11)] 
		[RED("isAStreetName")] 
		public CBool IsAStreetName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("streetNameSignTDBID")] 
		public TweakDBID StreetNameSignTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("signSelector")] 
		public CHandle<inkTweakDBIDSelector> SignSelector
		{
			get => GetPropertyValue<CHandle<inkTweakDBIDSelector>>();
			set => SetPropertyValue<CHandle<inkTweakDBIDSelector>>(value);
		}

		[Ordinal(14)] 
		[RED("signVersion")] 
		public CUInt32 SignVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public StreetSignWidgetComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			TintColor = new();
			ScreenAreaMultiplier = 1.000000F;
			IsEnabled = true;
		}
	}
}
