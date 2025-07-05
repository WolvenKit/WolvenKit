
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIExtendTargetCirclingCond_Record
	{
		[RED("destinationTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DestinationTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("spreadIncreaseAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpreadIncreaseAngle
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
	}
}
