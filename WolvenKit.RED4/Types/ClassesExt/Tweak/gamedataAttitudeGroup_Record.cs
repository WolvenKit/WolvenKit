
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttitudeGroup_Record
	{
		[RED("attitudeToSelf")]
		[REDProperty(IsIgnored = true)]
		public CString AttitudeToSelf
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("defaultAttitude")]
		[REDProperty(IsIgnored = true)]
		public CString DefaultAttitude
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("isState")]
		[REDProperty(IsIgnored = true)]
		public CBool IsState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("parent")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Parent
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
