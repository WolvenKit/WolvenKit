using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBaseUseWorkspotCommand : AICommand
	{
		private CBool _moveToWorkspot;
		private CName _forceEntryAnimName;
		private CArray<workWorkEntryId> _workExcludedGestures;
		private workWorkEntryId _infiniteSequenceEntryId;
		private CBool _idleOnlyMode;
		private CBool _continueInCombat;
		private CEnum<moveMovementType> _movementType;

		[Ordinal(4)] 
		[RED("moveToWorkspot")] 
		public CBool MoveToWorkspot
		{
			get => GetProperty(ref _moveToWorkspot);
			set => SetProperty(ref _moveToWorkspot, value);
		}

		[Ordinal(5)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get => GetProperty(ref _forceEntryAnimName);
			set => SetProperty(ref _forceEntryAnimName, value);
		}

		[Ordinal(6)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get => GetProperty(ref _workExcludedGestures);
			set => SetProperty(ref _workExcludedGestures, value);
		}

		[Ordinal(7)] 
		[RED("infiniteSequenceEntryId")] 
		public workWorkEntryId InfiniteSequenceEntryId
		{
			get => GetProperty(ref _infiniteSequenceEntryId);
			set => SetProperty(ref _infiniteSequenceEntryId, value);
		}

		[Ordinal(8)] 
		[RED("idleOnlyMode")] 
		public CBool IdleOnlyMode
		{
			get => GetProperty(ref _idleOnlyMode);
			set => SetProperty(ref _idleOnlyMode, value);
		}

		[Ordinal(9)] 
		[RED("continueInCombat")] 
		public CBool ContinueInCombat
		{
			get => GetProperty(ref _continueInCombat);
			set => SetProperty(ref _continueInCombat, value);
		}

		[Ordinal(10)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		public AIBaseUseWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
