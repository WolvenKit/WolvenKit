using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseStimInvestigateData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("distrationPoint")] 
		public Vector4 DistrationPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("attackInstigatorPosition")] 
		public Vector4 AttackInstigatorPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("investigationSpots")] 
		public CArray<Vector4> InvestigationSpots
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(3)] 
		[RED("controllerEntity")] 
		public CWeakHandle<entEntity> ControllerEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(4)] 
		[RED("mainDeviceEntity")] 
		public CWeakHandle<entEntity> MainDeviceEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(5)] 
		[RED("attackInstigator")] 
		public CWeakHandle<entEntity> AttackInstigator
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(6)] 
		[RED("victimEntity")] 
		public CWeakHandle<entEntity> VictimEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(7)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("revealsInstigatorPosition")] 
		public CBool RevealsInstigatorPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("illegalAction")] 
		public CBool IllegalAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("skipReactionDelay")] 
		public CBool SkipReactionDelay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("skipInitialAnimation")] 
		public CBool SkipInitialAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public senseStimInvestigateData()
		{
			DistrationPoint = new();
			AttackInstigatorPosition = new();
			InvestigationSpots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
