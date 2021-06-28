using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterAim_ConditionType : questICharacterConditionType
	{
		private CBool _isPlayer;
		private CBool _preciseAiming;
		private gameEntityReference _targetRef;

		[Ordinal(0)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(1)] 
		[RED("preciseAiming")] 
		public CBool PreciseAiming
		{
			get => GetProperty(ref _preciseAiming);
			set => SetProperty(ref _preciseAiming, value);
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		public questCharacterAim_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
