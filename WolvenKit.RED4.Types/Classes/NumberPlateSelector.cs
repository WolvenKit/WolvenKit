using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NumberPlateSelector : LCDScreenSelector
	{
		[Ordinal(4)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public NumberPlateSelector()
		{
			ReplaceTextWithCustomNumber = true;
		}
	}
}
