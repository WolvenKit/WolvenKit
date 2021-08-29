using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakspotOnDestroyEvent : redEvent
	{
		private WeakspotRecordData _weakspotRecordData;

		[Ordinal(0)] 
		[RED("weakspotRecordData")] 
		public WeakspotRecordData WeakspotRecordData
		{
			get => GetProperty(ref _weakspotRecordData);
			set => SetProperty(ref _weakspotRecordData, value);
		}
	}
}
