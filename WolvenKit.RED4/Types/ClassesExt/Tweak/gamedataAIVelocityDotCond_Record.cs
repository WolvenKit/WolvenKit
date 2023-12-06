
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIVelocityDotCond_Record
	{
		[RED("dotRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 DotRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("effectorClassName")]
		[REDProperty(IsIgnored = true)]
		public CBool EffectorClassName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("positionTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PositionTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("timePeriod")]
		[REDProperty(IsIgnored = true)]
		public CFloat TimePeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("velocityTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VelocityTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
