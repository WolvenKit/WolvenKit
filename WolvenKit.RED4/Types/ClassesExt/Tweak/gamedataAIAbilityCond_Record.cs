
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIAbilityCond_Record
	{
		[RED("abilities")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Abilities
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
