using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterAttack_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _attackerRef;
		private gameEntityReference _targetRef;
		private CBool _isTargetPlayer;

		[Ordinal(0)] 
		[RED("attackerRef")] 
		public gameEntityReference AttackerRef
		{
			get => GetProperty(ref _attackerRef);
			set => SetProperty(ref _attackerRef, value);
		}

		[Ordinal(1)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(2)] 
		[RED("isTargetPlayer")] 
		public CBool IsTargetPlayer
		{
			get => GetProperty(ref _isTargetPlayer);
			set => SetProperty(ref _isTargetPlayer, value);
		}

		public questCharacterAttack_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
