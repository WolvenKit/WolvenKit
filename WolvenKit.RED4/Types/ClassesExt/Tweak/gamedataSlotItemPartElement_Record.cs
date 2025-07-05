
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSlotItemPartElement_Record
	{
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
