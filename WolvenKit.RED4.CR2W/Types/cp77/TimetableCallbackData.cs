using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimetableCallbackData : IScriptable
	{
		private SSimpleGameTime _time;
		private CArray<RecipientData> _recipients;
		private CUInt32 _callbackID;

		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("recipients")] 
		public CArray<RecipientData> Recipients
		{
			get => GetProperty(ref _recipients);
			set => SetProperty(ref _recipients, value);
		}

		[Ordinal(2)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}

		public TimetableCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
