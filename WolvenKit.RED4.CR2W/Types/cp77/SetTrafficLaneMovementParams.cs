using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetTrafficLaneMovementParams : AIbehaviortaskScript
	{
		private CString _movementType;
		private CEnum<gameFearStage> _fearStage;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CString MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(1)] 
		[RED("fearStage")] 
		public CEnum<gameFearStage> FearStage
		{
			get => GetProperty(ref _fearStage);
			set => SetProperty(ref _fearStage, value);
		}

		public SetTrafficLaneMovementParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
