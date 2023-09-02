using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StreetSignWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(12)] 
		[RED("streetSignTDBID")] 
		public TweakDBID StreetSignTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("isAStreetName")] 
		public CBool IsAStreetName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("streetNameSignTDBID")] 
		public TweakDBID StreetNameSignTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(15)] 
		[RED("signSelector")] 
		public CHandle<inkTweakDBIDSelector> SignSelector
		{
			get => GetPropertyValue<CHandle<inkTweakDBIDSelector>>();
			set => SetPropertyValue<CHandle<inkTweakDBIDSelector>>(value);
		}

		[Ordinal(16)] 
		[RED("signVersion")] 
		public CUInt32 SignVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public StreetSignWidgetComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			TintColor = new CColor();
			ScreenAreaMultiplier = 1.000000F;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
