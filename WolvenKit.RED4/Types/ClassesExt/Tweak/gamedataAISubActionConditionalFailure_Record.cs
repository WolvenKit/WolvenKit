
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionConditionalFailure_Record
	{
		[RED("condition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Condition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("cooldowns")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Cooldowns
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
