
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionStatusEffect_Record
	{
		[RED("apply")]
		[REDProperty(IsIgnored = true)]
		public CBool Apply
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
		
		[RED("remove")]
		[REDProperty(IsIgnored = true)]
		public CBool Remove
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statusEffects")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatusEffects
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
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
