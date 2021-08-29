using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningTooltipElementDef : RedBaseClass
	{
		private TweakDBID _recordID;
		private CFloat _timePct;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("timePct")] 
		public CFloat TimePct
		{
			get => GetProperty(ref _timePct);
			set => SetProperty(ref _timePct, value);
		}
	}
}
