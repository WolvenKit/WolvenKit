
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCraftingResult_Record
	{
		[RED("amount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("item")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Item
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
