
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionThrowItem_Record
	{
		[RED("attachmentSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttachmentSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("checkThrowQuery")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckThrowQuery
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dropItemOnInterruption")]
		[REDProperty(IsIgnored = true)]
		public CBool DropItemOnInterruption
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("positionPredictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PositionPredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("throwAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThrowAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("throwType")]
		[REDProperty(IsIgnored = true)]
		public CName ThrowType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("trajectoryGravity")]
		[REDProperty(IsIgnored = true)]
		public CFloat TrajectoryGravity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
