using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryPostMortem : CVariable
	{
		private CString _crashVisitId;
		private CString _playthroughId;
		private CString _crashVersion;
		private CString _timeCrash;
		private gameTelemetryTrackedQuest _trackedQuest;
		private Vector3 _location;
		private CFloat _sessionLength;
		private CBool _isOom;

		[Ordinal(0)] 
		[RED("crashVisitId")] 
		public CString CrashVisitId
		{
			get => GetProperty(ref _crashVisitId);
			set => SetProperty(ref _crashVisitId, value);
		}

		[Ordinal(1)] 
		[RED("playthroughId")] 
		public CString PlaythroughId
		{
			get => GetProperty(ref _playthroughId);
			set => SetProperty(ref _playthroughId, value);
		}

		[Ordinal(2)] 
		[RED("crashVersion")] 
		public CString CrashVersion
		{
			get => GetProperty(ref _crashVersion);
			set => SetProperty(ref _crashVersion, value);
		}

		[Ordinal(3)] 
		[RED("timeCrash")] 
		public CString TimeCrash
		{
			get => GetProperty(ref _timeCrash);
			set => SetProperty(ref _timeCrash, value);
		}

		[Ordinal(4)] 
		[RED("trackedQuest")] 
		public gameTelemetryTrackedQuest TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(5)] 
		[RED("location")] 
		public Vector3 Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}

		[Ordinal(6)] 
		[RED("sessionLength")] 
		public CFloat SessionLength
		{
			get => GetProperty(ref _sessionLength);
			set => SetProperty(ref _sessionLength, value);
		}

		[Ordinal(7)] 
		[RED("isOom")] 
		public CBool IsOom
		{
			get => GetProperty(ref _isOom);
			set => SetProperty(ref _isOom, value);
		}

		public gameTelemetryPostMortem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
