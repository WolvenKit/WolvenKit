
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatsFolder_Record
	{
		[RED("arrays")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Arrays
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("folders")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Folders
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("stats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Stats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
