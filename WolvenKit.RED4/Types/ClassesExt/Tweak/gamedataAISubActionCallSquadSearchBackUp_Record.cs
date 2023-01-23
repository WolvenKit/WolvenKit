
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionCallSquadSearchBackUp_Record
	{
		[RED("callInLevel")]
		[REDProperty(IsIgnored = true)]
		public CFloat CallInLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("numberOfTargets")]
		[REDProperty(IsIgnored = true)]
		public CFloat NumberOfTargets
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
