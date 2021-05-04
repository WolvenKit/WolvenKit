using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WoundedTriggeredPrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CUInt32 _listenerInt;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("listenerInt")] 
		public CUInt32 ListenerInt
		{
			get => GetProperty(ref _listenerInt);
			set => SetProperty(ref _listenerInt, value);
		}

		public WoundedTriggeredPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
