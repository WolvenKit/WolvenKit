
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeightedCharacter_Record
	{
		[RED("character")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Character
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
