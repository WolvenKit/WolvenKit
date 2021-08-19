using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachinePrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CHandle<redCallbackObject> _listenerInt;
		private CInt32 _prevValue;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("listenerInt")] 
		public CHandle<redCallbackObject> ListenerInt
		{
			get => GetProperty(ref _listenerInt);
			set => SetProperty(ref _listenerInt, value);
		}

		[Ordinal(2)] 
		[RED("prevValue")] 
		public CInt32 PrevValue
		{
			get => GetProperty(ref _prevValue);
			set => SetProperty(ref _prevValue, value);
		}

		public PlayerStateMachinePrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
