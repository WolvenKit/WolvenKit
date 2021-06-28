using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddOrRemoveListenerEvent : redEvent
	{
		private CHandle<PuppetListener> _listener;
		private CBool _add;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<PuppetListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("add")] 
		public CBool Add
		{
			get => GetProperty(ref _add);
			set => SetProperty(ref _add, value);
		}

		public AddOrRemoveListenerEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
