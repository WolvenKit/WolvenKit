
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionCreateGameEffect_Record
	{
		[RED("colliderBoxSize")]
		[REDProperty(IsIgnored = true)]
		public Vector3 ColliderBoxSize
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("effectName")]
		[REDProperty(IsIgnored = true)]
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectTag")]
		[REDProperty(IsIgnored = true)]
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("positionObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PositionObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotationObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RotationObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("targetPositionObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TargetPositionObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
