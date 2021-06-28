using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDetectingPlayerPrereqState : gamePrereqState
	{
		private wCHandle<gameObject> _owner;
		private CUInt32 _listenerID;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get => GetProperty(ref _listenerID);
			set => SetProperty(ref _listenerID, value);
		}

		public NPCDetectingPlayerPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
