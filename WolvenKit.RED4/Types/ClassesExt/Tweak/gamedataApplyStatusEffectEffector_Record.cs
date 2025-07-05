
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyStatusEffectEffector_Record
	{
		[RED("applicationTarget")]
		[REDProperty(IsIgnored = true)]
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("count")]
		[REDProperty(IsIgnored = true)]
		public CFloat Count
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("instigator")]
		[REDProperty(IsIgnored = true)]
		public CString Instigator
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("inverted")]
		[REDProperty(IsIgnored = true)]
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("removeWithEffector")]
		[REDProperty(IsIgnored = true)]
		public CBool RemoveWithEffector
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statusEffect")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("useCountWhenRemoving")]
		[REDProperty(IsIgnored = true)]
		public CBool UseCountWhenRemoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
