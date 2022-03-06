
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSlotItemPartPreset_Record
	{
		[RED("itemPartList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemPartList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("itemPartPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemPartPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("slot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Slot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
