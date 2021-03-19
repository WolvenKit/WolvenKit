using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToState : gameActionReplicatedState
	{
		private Vector3 _targetPos;
		private CFloat _toleranceRadius;
		private CBool _rotateEntity;
		private CUInt32 _moveStyle;

		[Ordinal(5)] 
		[RED("targetPos")] 
		public Vector3 TargetPos
		{
			get => GetProperty(ref _targetPos);
			set => SetProperty(ref _targetPos, value);
		}

		[Ordinal(6)] 
		[RED("toleranceRadius")] 
		public CFloat ToleranceRadius
		{
			get => GetProperty(ref _toleranceRadius);
			set => SetProperty(ref _toleranceRadius, value);
		}

		[Ordinal(7)] 
		[RED("rotateEntity")] 
		public CBool RotateEntity
		{
			get => GetProperty(ref _rotateEntity);
			set => SetProperty(ref _rotateEntity, value);
		}

		[Ordinal(8)] 
		[RED("moveStyle")] 
		public CUInt32 MoveStyle
		{
			get => GetProperty(ref _moveStyle);
			set => SetProperty(ref _moveStyle, value);
		}

		public gameActionMoveToState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
