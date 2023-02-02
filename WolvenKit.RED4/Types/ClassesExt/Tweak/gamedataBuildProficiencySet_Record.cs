
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildProficiencySet_Record
	{
		[RED("proficiencies")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Proficiencies
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
