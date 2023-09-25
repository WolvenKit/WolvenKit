using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehiclePreventionHackState : IScriptable
	{
		[Ordinal(0)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleID")] 
		public entEntityID VehicleID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("progressBarProgressSoFar")] 
		public CFloat ProgressBarProgressSoFar
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("progressBarProgressStart")] 
		public CFloat ProgressBarProgressStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("hacked")] 
		public CBool Hacked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hackInProgress")] 
		public CBool HackInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("stoppedVehicle")] 
		public CBool StoppedVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("progressBar")] 
		public CWeakHandle<UploadFromNPCToPlayerListener> ProgressBar
		{
			get => GetPropertyValue<CWeakHandle<UploadFromNPCToPlayerListener>>();
			set => SetPropertyValue<CWeakHandle<UploadFromNPCToPlayerListener>>(value);
		}

		[Ordinal(8)] 
		[RED("appliedHackSpeed")] 
		public CEnum<EAppliedTriangulationHackSpeed> AppliedHackSpeed
		{
			get => GetPropertyValue<CEnum<EAppliedTriangulationHackSpeed>>();
			set => SetPropertyValue<CEnum<EAppliedTriangulationHackSpeed>>(value);
		}

		public VehiclePreventionHackState()
		{
			VehicleID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
