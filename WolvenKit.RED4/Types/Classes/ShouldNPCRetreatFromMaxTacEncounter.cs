using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShouldNPCRetreatFromMaxTacEncounter : PreventionConditionAbstract
	{
		[Ordinal(0)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetPropertyValue<CHandle<PoliceAgentRegistry>>();
			set => SetPropertyValue<CHandle<PoliceAgentRegistry>>(value);
		}

		[Ordinal(1)] 
		[RED("threatLocation")] 
		public AITrackedLocation ThreatLocation
		{
			get => GetPropertyValue<AITrackedLocation>();
			set => SetPropertyValue<AITrackedLocation>(value);
		}

		public ShouldNPCRetreatFromMaxTacEncounter()
		{
			ThreatLocation = new AITrackedLocation { LastKnown = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } }, Location = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } }, SharedLocation = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } }, Accuracy = 1.000000F, SharedAccuracy = 1.000000F, Speed = new Vector4(), SharedLastKnown = new AILocationInformation { Position = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity }, Direction = new Vector4 { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity, W = float.PositiveInfinity } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
