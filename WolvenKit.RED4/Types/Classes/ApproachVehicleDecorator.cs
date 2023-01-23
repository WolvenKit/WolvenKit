using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApproachVehicleDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("mountRequest")] 
		public CHandle<AIArgumentMapping> MountRequest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("entryPoint")] 
		public CHandle<AIArgumentMapping> EntryPoint
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("doorOpenRequestSent")] 
		public CBool DoorOpenRequestSent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("closeDoor")] 
		public CBool CloseDoor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("mountEventData")] 
		public CHandle<gameMountEventData> MountEventData
		{
			get => GetPropertyValue<CHandle<gameMountEventData>>();
			set => SetPropertyValue<CHandle<gameMountEventData>>(value);
		}

		[Ordinal(6)] 
		[RED("mountRequestData")] 
		public CHandle<gameMountEventData> MountRequestData
		{
			get => GetPropertyValue<CHandle<gameMountEventData>>();
			set => SetPropertyValue<CHandle<gameMountEventData>>(value);
		}

		[Ordinal(7)] 
		[RED("mountEntryPoint")] 
		public Vector4 MountEntryPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("activationTime")] 
		public EngineTime ActivationTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(9)] 
		[RED("runCompanionCheck")] 
		public CBool RunCompanionCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ApproachVehicleDecorator()
		{
			MountEntryPoint = new();
			ActivationTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
