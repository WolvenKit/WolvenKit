using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		private CHandle<redEvent> _eventToExecute;

		[Ordinal(1)] 
		[RED("eventToExecute")] 
		public CHandle<redEvent> EventToExecute
		{
			get => GetProperty(ref _eventToExecute);
			set => SetProperty(ref _eventToExecute, value);
		}

		public inkanimExecuteCodeEventEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
