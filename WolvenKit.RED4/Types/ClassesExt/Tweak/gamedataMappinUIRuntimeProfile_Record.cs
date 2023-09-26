
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUIRuntimeProfile_Record
	{
		[RED("clampEllipseSize")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ClampEllipseSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("clampingParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ClampingParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("clampRectMargin")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ClampRectMargin
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("clampX")]
		[REDProperty(IsIgnored = true)]
		public CBool ClampX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("clampY")]
		[REDProperty(IsIgnored = true)]
		public CBool ClampY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("dynamicClamping")]
		[REDProperty(IsIgnored = true)]
		public CBool DynamicClamping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hoverRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat HoverRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isLoot")]
		[REDProperty(IsIgnored = true)]
		public CBool IsLoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("keepNameplate")]
		[REDProperty(IsIgnored = true)]
		public CBool KeepNameplate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("opacityAngleParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OpacityAngleParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("opacityCustomParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OpacityCustomParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("opacityDistanceParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OpacityDistanceParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("scaleByDistance")]
		[REDProperty(IsIgnored = true)]
		public CBool ScaleByDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("scaleDistanceParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ScaleDistanceParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("scaleDistanceScanningParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ScaleDistanceScanningParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("screenOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ScreenOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("showDistance")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("showDistanceMinRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat ShowDistanceMinRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("showNameMinRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat ShowNameMinRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("showTrackedIcon")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowTrackedIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useQuestProperties")]
		[REDProperty(IsIgnored = true)]
		public CBool UseQuestProperties
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("visibleInBraindance")]
		[REDProperty(IsIgnored = true)]
		public CBool VisibleInBraindance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("visibleInScanning")]
		[REDProperty(IsIgnored = true)]
		public CBool VisibleInScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("visibleInTier")]
		[REDProperty(IsIgnored = true)]
		public CArray<CBool> VisibleInTier
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}
		
		[RED("worldOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 WorldOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
