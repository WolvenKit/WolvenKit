using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redTaskTextMessage : CVariable
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

		public redTaskTextMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
