
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGameplayAbilityGroup_Record
	{
		[RED("abilities")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Abilities
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
