using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendSpiderbotToPerformActionEvent : redEvent
	{
		private wCHandle<gameObject> _executor;

		[Ordinal(0)] 
		[RED("executor")] 
		public wCHandle<gameObject> Executor
		{
			get => GetProperty(ref _executor);
			set => SetProperty(ref _executor, value);
		}

		public SendSpiderbotToPerformActionEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
