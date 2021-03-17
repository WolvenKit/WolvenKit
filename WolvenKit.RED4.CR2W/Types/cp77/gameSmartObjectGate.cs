using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectGate : CVariable
	{
		private CName _animationName;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveMovementOrientationType> _movementOrientationType;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(2)] 
		[RED("movementOrientationType")] 
		public CEnum<moveMovementOrientationType> MovementOrientationType
		{
			get => GetProperty(ref _movementOrientationType);
			set => SetProperty(ref _movementOrientationType, value);
		}

		public gameSmartObjectGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
