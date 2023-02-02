using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetryPostMortem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crashVisitId")] 
		public CString CrashVisitId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("playthroughId")] 
		public CString PlaythroughId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("crashVersion")] 
		public CString CrashVersion
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("crashPatch")] 
		public CString CrashPatch
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("timeCrash")] 
		public CString TimeCrash
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("district")] 
		public CString District
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("zoneType")] 
		public CString ZoneType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("trackedQuest")] 
		public gameTelemetryTrackedQuest TrackedQuest
		{
			get => GetPropertyValue<gameTelemetryTrackedQuest>();
			set => SetPropertyValue<gameTelemetryTrackedQuest>(value);
		}

		[Ordinal(8)] 
		[RED("location")] 
		public Vector3 Location
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("sessionLength")] 
		public CFloat SessionLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("isOom")] 
		public CBool IsOom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameTelemetryPostMortem()
		{
			TrackedQuest = new();
			Location = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
