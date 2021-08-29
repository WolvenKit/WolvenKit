using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worlduiIWidgetGameController : inkIWidgetController
	{
		private TweakDBID _elementRecordID;

		[Ordinal(1)] 
		[RED("elementRecordID")] 
		public TweakDBID ElementRecordID
		{
			get => GetProperty(ref _elementRecordID);
			set => SetProperty(ref _elementRecordID, value);
		}
	}
}
