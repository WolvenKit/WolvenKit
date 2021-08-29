using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScreenMessageData : IScriptable
	{
		private CHandle<gamedataScreenMessageData_Record> _messageRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;

		[Ordinal(0)] 
		[RED("messageRecord")] 
		public CHandle<gamedataScreenMessageData_Record> MessageRecord
		{
			get => GetProperty(ref _messageRecord);
			set => SetProperty(ref _messageRecord, value);
		}

		[Ordinal(1)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get => GetProperty(ref _replaceTextWithCustomNumber);
			set => SetProperty(ref _replaceTextWithCustomNumber, value);
		}

		[Ordinal(2)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get => GetProperty(ref _customNumber);
			set => SetProperty(ref _customNumber, value);
		}
	}
}
