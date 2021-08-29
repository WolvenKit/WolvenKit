using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerQuickhackData : RedBaseClass
	{
		private CWeakHandle<gamedataObjectAction_Record> _actionRecord;
		private CInt32 _quality;

		[Ordinal(0)] 
		[RED("actionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ActionRecord
		{
			get => GetProperty(ref _actionRecord);
			set => SetProperty(ref _actionRecord, value);
		}

		[Ordinal(1)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}
	}
}
