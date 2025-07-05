
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadDistanceRelationToTargetCheck_Record
	{
		[RED("ringRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat RingRadius
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
