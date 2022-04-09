using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMoveOnSplineParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("splineNodeRef")] 
		public NodeRef SplineNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("additionalParams")] 
		public CHandle<questMoveOnSplineAdditionalParams> AdditionalParams
		{
			get => GetPropertyValue<CHandle<questMoveOnSplineAdditionalParams>>();
			set => SetPropertyValue<CHandle<questMoveOnSplineAdditionalParams>>(value);
		}

		[Ordinal(6)] 
		[RED("useAlertedState")] 
		public CBool UseAlertedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("useCombatState")] 
		public CBool UseCombatState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("executeWhileDespawned")] 
		public CBool ExecuteWhileDespawned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("noWaitToEndDistance")] 
		public CFloat NoWaitToEndDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("noWaitToEndCompanionDistance")] 
		public CFloat NoWaitToEndCompanionDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMoveOnSplineParams()
		{
			UseStart = true;
			UseStop = true;
			ExecuteWhileDespawned = true;
			RepeatCommandOnInterrupt = true;
			NoWaitToEndDistance = 10.000000F;
			NoWaitToEndCompanionDistance = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
