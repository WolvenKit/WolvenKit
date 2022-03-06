
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCodex_Record
	{
		[RED("entries")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Entries
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
