using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QHackWheelItemChangedEvent : redEvent
	{
		private CHandle<QuickhackData> _commandData;
		private CBool _currentEmpty;

		[Ordinal(0)] 
		[RED("commandData")] 
		public CHandle<QuickhackData> CommandData
		{
			get => GetProperty(ref _commandData);
			set => SetProperty(ref _commandData, value);
		}

		[Ordinal(1)] 
		[RED("currentEmpty")] 
		public CBool CurrentEmpty
		{
			get => GetProperty(ref _currentEmpty);
			set => SetProperty(ref _currentEmpty, value);
		}

		public QHackWheelItemChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
