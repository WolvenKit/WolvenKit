
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCodexRecord_Record
	{
		[RED("recordContent")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RecordContent
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("unlockedFromStart")]
		[REDProperty(IsIgnored = true)]
		public CBool UnlockedFromStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("unlockPrereq")]
		[REDProperty(IsIgnored = true)]
		public CName UnlockPrereq
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
