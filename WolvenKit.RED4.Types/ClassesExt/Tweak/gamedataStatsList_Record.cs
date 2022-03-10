
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatsList_Record
	{
		[RED("stats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Stats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
