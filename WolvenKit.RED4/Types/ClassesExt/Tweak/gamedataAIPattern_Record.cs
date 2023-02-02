
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIPattern_Record
	{
		[RED("activationConditions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ActivationConditions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("delays")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Delays
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("patternSize")]
		[REDProperty(IsIgnored = true)]
		public CInt32 PatternSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
