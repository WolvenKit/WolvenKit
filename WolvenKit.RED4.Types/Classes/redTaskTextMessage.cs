using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redTaskTextMessage : RedBaseClass
	{
		private CUInt32 _taskId;
		private CString _text;
		private CEnum<redTaskTextMessageType> _type;

		[Ordinal(0)] 
		[RED("taskId")] 
		public CUInt32 TaskId
		{
			get => GetProperty(ref _taskId);
			set => SetProperty(ref _taskId, value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<redTaskTextMessageType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
