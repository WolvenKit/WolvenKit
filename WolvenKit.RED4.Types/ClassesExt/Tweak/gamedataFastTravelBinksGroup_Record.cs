
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFastTravelBinksGroup_Record
	{
		[RED("binksData")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> BinksData
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
