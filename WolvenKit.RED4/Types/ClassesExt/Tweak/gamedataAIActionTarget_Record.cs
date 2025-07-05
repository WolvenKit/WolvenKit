
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionTarget_Record
	{
		[RED("behaviorArgumentName")]
		[REDProperty(IsIgnored = true)]
		public CName BehaviorArgumentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("isCoverID")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCoverID
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isObject")]
		[REDProperty(IsIgnored = true)]
		public CBool IsObject
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isPosition")]
		[REDProperty(IsIgnored = true)]
		public CBool IsPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("targetSlot")]
		[REDProperty(IsIgnored = true)]
		public CName TargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("trackingMode")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TrackingMode
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
