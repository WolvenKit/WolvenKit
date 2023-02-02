
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinPhaseDefinition_Record
	{
		[RED("phase")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Phase
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("variant")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Variant
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
