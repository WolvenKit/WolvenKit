using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_Kill : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _noAnimation;
		private CBool _noRagdoll;
		private CBool _skipDefeatedState;
		private CBool _doDismemberment;
		private CEnum<physicsRagdollBodyPartE> _bodyPart;
		private CEnum<entdismembermentWoundTypeE> _woundType;
		private CFloat _dismembermentStrenght;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("noAnimation")] 
		public CBool NoAnimation
		{
			get => GetProperty(ref _noAnimation);
			set => SetProperty(ref _noAnimation, value);
		}

		[Ordinal(3)] 
		[RED("noRagdoll")] 
		public CBool NoRagdoll
		{
			get => GetProperty(ref _noRagdoll);
			set => SetProperty(ref _noRagdoll, value);
		}

		[Ordinal(4)] 
		[RED("skipDefeatedState")] 
		public CBool SkipDefeatedState
		{
			get => GetProperty(ref _skipDefeatedState);
			set => SetProperty(ref _skipDefeatedState, value);
		}

		[Ordinal(5)] 
		[RED("doDismemberment")] 
		public CBool DoDismemberment
		{
			get => GetProperty(ref _doDismemberment);
			set => SetProperty(ref _doDismemberment, value);
		}

		[Ordinal(6)] 
		[RED("bodyPart")] 
		public CEnum<physicsRagdollBodyPartE> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(7)] 
		[RED("woundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get => GetProperty(ref _woundType);
			set => SetProperty(ref _woundType, value);
		}

		[Ordinal(8)] 
		[RED("dismembermentStrenght")] 
		public CFloat DismembermentStrenght
		{
			get => GetProperty(ref _dismembermentStrenght);
			set => SetProperty(ref _dismembermentStrenght, value);
		}

		public questCharacterManagerCombat_Kill(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
