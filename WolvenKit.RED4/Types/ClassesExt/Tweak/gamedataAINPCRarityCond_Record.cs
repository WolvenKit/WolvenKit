
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAINPCRarityCond_Record
	{
		[RED("rarity")]
		[REDProperty(IsIgnored = true)]
		public CString Rarity
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
