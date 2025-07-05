
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRoachRaceBackground_Record
	{
		[RED("isSunAndMoonVisible")]
		[REDProperty(IsIgnored = true)]
		public CBool IsSunAndMoonVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("layerList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LayerList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("objectList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObjectList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startSFX")]
		[REDProperty(IsIgnored = true)]
		public CName StartSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("stopSFX")]
		[REDProperty(IsIgnored = true)]
		public CName StopSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
