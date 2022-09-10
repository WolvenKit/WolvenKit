
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeScoreboard_Record
	{
		[RED("arcadeScoreboardEntryList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ArcadeScoreboardEntryList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("arcadeScoreboardHighScoreSFX")]
		[REDProperty(IsIgnored = true)]
		public CName ArcadeScoreboardHighScoreSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("arcadeScoreboardQuestFactList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ArcadeScoreboardQuestFactList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
