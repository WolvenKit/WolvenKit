
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildPerkSet_Record
	{
		[RED("perks")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Perks
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
