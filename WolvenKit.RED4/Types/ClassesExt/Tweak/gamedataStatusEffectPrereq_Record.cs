
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectPrereq_Record
	{
		[RED("checkType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CheckType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("evaluateOnRegister")]
		[REDProperty(IsIgnored = true)]
		public CBool EvaluateOnRegister
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("objectToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName ObjectToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("statusEffect")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tagToCheck")]
		[REDProperty(IsIgnored = true)]
		public CName TagToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
