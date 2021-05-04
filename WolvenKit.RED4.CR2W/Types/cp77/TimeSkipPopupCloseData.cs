using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimeSkipPopupCloseData : inkGameNotificationData
	{
		private CBool _timeChanged;

		[Ordinal(6)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get => GetProperty(ref _timeChanged);
			set => SetProperty(ref _timeChanged, value);
		}

		public TimeSkipPopupCloseData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
