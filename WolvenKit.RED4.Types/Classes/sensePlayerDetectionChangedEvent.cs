using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sensePlayerDetectionChangedEvent : redEvent
	{
		private CFloat _oldDetectionValue;
		private CFloat _newDetectionValue;

		[Ordinal(0)] 
		[RED("oldDetectionValue")] 
		public CFloat OldDetectionValue
		{
			get => GetProperty(ref _oldDetectionValue);
			set => SetProperty(ref _oldDetectionValue, value);
		}

		[Ordinal(1)] 
		[RED("newDetectionValue")] 
		public CFloat NewDetectionValue
		{
			get => GetProperty(ref _newDetectionValue);
			set => SetProperty(ref _newDetectionValue, value);
		}
	}
}
