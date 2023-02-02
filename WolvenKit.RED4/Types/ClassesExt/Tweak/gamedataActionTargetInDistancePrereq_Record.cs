
namespace WolvenKit.RED4.Types
{
	public partial class gamedataActionTargetInDistancePrereq_Record
	{
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
