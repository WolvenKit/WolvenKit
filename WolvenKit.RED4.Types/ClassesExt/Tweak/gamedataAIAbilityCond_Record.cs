
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
		
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
