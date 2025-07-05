
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDistrict_Record
	{
		[RED("crimeMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat CrimeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CString EnumName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("explosiveDeviceStimRangeMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat ExplosiveDeviceStimRangeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gangs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Gangs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("gunShotStimRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat GunShotStimRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isQuestDistrict")]
		[REDProperty(IsIgnored = true)]
		public CBool IsQuestDistrict
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("parentDistrict")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ParentDistrict
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("policeRadioSceneEntryPoint")]
		[REDProperty(IsIgnored = true)]
		public CName PoliceRadioSceneEntryPoint
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("preventionPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PreventionPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("uiIcon")]
		[REDProperty(IsIgnored = true)]
		public CName UiIcon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("uiState")]
		[REDProperty(IsIgnored = true)]
		public CName UiState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
