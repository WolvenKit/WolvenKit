using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMoveOnSplineParams : questAICommandParams
	{
		private NodeRef _splineNodeRef;
		private CBool _useStart;
		private CBool _useStop;
		private CBool _reverse;
		private CBool _startFromClosestPoint;
		private CHandle<questMoveOnSplineAdditionalParams> _additionalParams;
		private CBool _useAlertedState;
		private CBool _useCombatState;
		private CBool _executeWhileDespawned;
		private CBool _repeatCommandOnInterrupt;
		private CFloat _noWaitToEndDistance;
		private CFloat _noWaitToEndCompanionDistance;
		private CBool _removeAfterCombat;
		private CBool _ignoreInCombat;
		private CBool _alwaysUseStealth;

		[Ordinal(0)] 
		[RED("splineNodeRef")] 
		public NodeRef SplineNodeRef
		{
			get => GetProperty(ref _splineNodeRef);
			set => SetProperty(ref _splineNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(2)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(3)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetProperty(ref _reverse);
			set => SetProperty(ref _reverse, value);
		}

		[Ordinal(4)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get => GetProperty(ref _startFromClosestPoint);
			set => SetProperty(ref _startFromClosestPoint, value);
		}

		[Ordinal(5)] 
		[RED("additionalParams")] 
		public CHandle<questMoveOnSplineAdditionalParams> AdditionalParams
		{
			get => GetProperty(ref _additionalParams);
			set => SetProperty(ref _additionalParams, value);
		}

		[Ordinal(6)] 
		[RED("useAlertedState")] 
		public CBool UseAlertedState
		{
			get => GetProperty(ref _useAlertedState);
			set => SetProperty(ref _useAlertedState, value);
		}

		[Ordinal(7)] 
		[RED("useCombatState")] 
		public CBool UseCombatState
		{
			get => GetProperty(ref _useCombatState);
			set => SetProperty(ref _useCombatState, value);
		}

		[Ordinal(8)] 
		[RED("executeWhileDespawned")] 
		public CBool ExecuteWhileDespawned
		{
			get => GetProperty(ref _executeWhileDespawned);
			set => SetProperty(ref _executeWhileDespawned, value);
		}

		[Ordinal(9)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetProperty(ref _repeatCommandOnInterrupt);
			set => SetProperty(ref _repeatCommandOnInterrupt, value);
		}

		[Ordinal(10)] 
		[RED("noWaitToEndDistance")] 
		public CFloat NoWaitToEndDistance
		{
			get => GetProperty(ref _noWaitToEndDistance);
			set => SetProperty(ref _noWaitToEndDistance, value);
		}

		[Ordinal(11)] 
		[RED("noWaitToEndCompanionDistance")] 
		public CFloat NoWaitToEndCompanionDistance
		{
			get => GetProperty(ref _noWaitToEndCompanionDistance);
			set => SetProperty(ref _noWaitToEndCompanionDistance, value);
		}

		[Ordinal(12)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get => GetProperty(ref _removeAfterCombat);
			set => SetProperty(ref _removeAfterCombat, value);
		}

		[Ordinal(13)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get => GetProperty(ref _ignoreInCombat);
			set => SetProperty(ref _ignoreInCombat, value);
		}

		[Ordinal(14)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetProperty(ref _alwaysUseStealth);
			set => SetProperty(ref _alwaysUseStealth, value);
		}

		public questMoveOnSplineParams()
		{
			_useStart = true;
			_useStop = true;
			_executeWhileDespawned = true;
			_repeatCommandOnInterrupt = true;
			_noWaitToEndDistance = 10.000000F;
			_noWaitToEndCompanionDistance = 5.000000F;
		}
	}
}
