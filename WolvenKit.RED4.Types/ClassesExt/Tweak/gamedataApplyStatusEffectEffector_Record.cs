
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyStatusEffectEffector_Record
	{
		[RED("count")]
		[REDProperty(IsIgnored = true)]
		public CFloat Count
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("effectorChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat EffectorChance
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
		
		[RED("isRandom")]
		[REDProperty(IsIgnored = true)]
		public CBool IsRandom
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
	}
}
