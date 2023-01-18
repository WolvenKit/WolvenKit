
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSlotItemPartListElement_Record
	{
		[RED("itemPartList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemPartList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("optionalProbabilityCurveName")]
		[REDProperty(IsIgnored = true)]
		public CString OptionalProbabilityCurveName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
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
