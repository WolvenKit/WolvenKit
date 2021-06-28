using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRumble_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		private CName _rumbleEvent;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;

		[Ordinal(0)] 
		[RED("rumbleEvent")] 
		public CName RumbleEvent
		{
			get => GetProperty(ref _rumbleEvent);
			set => SetProperty(ref _rumbleEvent, value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		public questRumble_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
