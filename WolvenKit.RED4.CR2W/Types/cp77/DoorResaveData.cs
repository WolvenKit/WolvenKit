using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorResaveData : CVariable
	{
		private CEnum<EDoorType> _doorType;
		private CBool _canPlayerToggleLockState;
		private CBool _canPlayerToggleSealState;
		private CEnum<EDoorStatus> _initialStatus;
		private TweakDBID _keycardName;
		private CName _passcode;

		[Ordinal(0)] 
		[RED("doorType")] 
		public CEnum<EDoorType> DoorType
		{
			get => GetProperty(ref _doorType);
			set => SetProperty(ref _doorType, value);
		}

		[Ordinal(1)] 
		[RED("canPlayerToggleLockState")] 
		public CBool CanPlayerToggleLockState
		{
			get => GetProperty(ref _canPlayerToggleLockState);
			set => SetProperty(ref _canPlayerToggleLockState, value);
		}

		[Ordinal(2)] 
		[RED("canPlayerToggleSealState")] 
		public CBool CanPlayerToggleSealState
		{
			get => GetProperty(ref _canPlayerToggleSealState);
			set => SetProperty(ref _canPlayerToggleSealState, value);
		}

		[Ordinal(3)] 
		[RED("initialStatus")] 
		public CEnum<EDoorStatus> InitialStatus
		{
			get => GetProperty(ref _initialStatus);
			set => SetProperty(ref _initialStatus, value);
		}

		[Ordinal(4)] 
		[RED("keycardName")] 
		public TweakDBID KeycardName
		{
			get => GetProperty(ref _keycardName);
			set => SetProperty(ref _keycardName, value);
		}

		[Ordinal(5)] 
		[RED("passcode")] 
		public CName Passcode
		{
			get => GetProperty(ref _passcode);
			set => SetProperty(ref _passcode, value);
		}

		public DoorResaveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
