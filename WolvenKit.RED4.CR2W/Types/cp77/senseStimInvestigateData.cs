using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseStimInvestigateData : CVariable
	{
		private Vector4 _distrationPoint;
		private Vector4 _attackInstigatorPosition;
		private CArray<Vector4> _investigationSpots;
		private wCHandle<entEntity> _controllerEntity;
		private wCHandle<entEntity> _mainDeviceEntity;
		private wCHandle<entEntity> _attackInstigator;
		private wCHandle<entEntity> _victimEntity;
		private CInt32 _fearPhase;
		private CBool _revealsInstigatorPosition;
		private CBool _illegalAction;
		private CBool _skipReactionDelay;
		private CBool _skipInitialAnimation;
		private CBool _investigateController;

		[Ordinal(0)] 
		[RED("distrationPoint")] 
		public Vector4 DistrationPoint
		{
			get => GetProperty(ref _distrationPoint);
			set => SetProperty(ref _distrationPoint, value);
		}

		[Ordinal(1)] 
		[RED("attackInstigatorPosition")] 
		public Vector4 AttackInstigatorPosition
		{
			get => GetProperty(ref _attackInstigatorPosition);
			set => SetProperty(ref _attackInstigatorPosition, value);
		}

		[Ordinal(2)] 
		[RED("investigationSpots")] 
		public CArray<Vector4> InvestigationSpots
		{
			get => GetProperty(ref _investigationSpots);
			set => SetProperty(ref _investigationSpots, value);
		}

		[Ordinal(3)] 
		[RED("controllerEntity")] 
		public wCHandle<entEntity> ControllerEntity
		{
			get => GetProperty(ref _controllerEntity);
			set => SetProperty(ref _controllerEntity, value);
		}

		[Ordinal(4)] 
		[RED("mainDeviceEntity")] 
		public wCHandle<entEntity> MainDeviceEntity
		{
			get => GetProperty(ref _mainDeviceEntity);
			set => SetProperty(ref _mainDeviceEntity, value);
		}

		[Ordinal(5)] 
		[RED("attackInstigator")] 
		public wCHandle<entEntity> AttackInstigator
		{
			get => GetProperty(ref _attackInstigator);
			set => SetProperty(ref _attackInstigator, value);
		}

		[Ordinal(6)] 
		[RED("victimEntity")] 
		public wCHandle<entEntity> VictimEntity
		{
			get => GetProperty(ref _victimEntity);
			set => SetProperty(ref _victimEntity, value);
		}

		[Ordinal(7)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get => GetProperty(ref _fearPhase);
			set => SetProperty(ref _fearPhase, value);
		}

		[Ordinal(8)] 
		[RED("revealsInstigatorPosition")] 
		public CBool RevealsInstigatorPosition
		{
			get => GetProperty(ref _revealsInstigatorPosition);
			set => SetProperty(ref _revealsInstigatorPosition, value);
		}

		[Ordinal(9)] 
		[RED("illegalAction")] 
		public CBool IllegalAction
		{
			get => GetProperty(ref _illegalAction);
			set => SetProperty(ref _illegalAction, value);
		}

		[Ordinal(10)] 
		[RED("skipReactionDelay")] 
		public CBool SkipReactionDelay
		{
			get => GetProperty(ref _skipReactionDelay);
			set => SetProperty(ref _skipReactionDelay, value);
		}

		[Ordinal(11)] 
		[RED("skipInitialAnimation")] 
		public CBool SkipInitialAnimation
		{
			get => GetProperty(ref _skipInitialAnimation);
			set => SetProperty(ref _skipInitialAnimation, value);
		}

		[Ordinal(12)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get => GetProperty(ref _investigateController);
			set => SetProperty(ref _investigateController, value);
		}

		public senseStimInvestigateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
