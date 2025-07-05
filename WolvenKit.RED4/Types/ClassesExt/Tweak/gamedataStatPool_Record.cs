
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatPool_Record
	{
		[RED("decay")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Decay
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enableDefeated")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableDefeated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
		
		[RED("initialValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat InitialValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("regen")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Regen
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("savable")]
		[REDProperty(IsIgnored = true)]
		public CBool Savable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("stat")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Stat
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
