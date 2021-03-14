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
			get
			{
				if (_crashVisitId == null)
				{
					_crashVisitId = (CString) CR2WTypeManager.Create("String", "crashVisitId", cr2w, this);
				}
				return _crashVisitId;
			}
			set
			{
				if (_crashVisitId == value)
				{
					return;
				}
				_crashVisitId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playthroughId")] 
		public CString PlaythroughId
		{
			get
			{
				if (_playthroughId == null)
				{
					_playthroughId = (CString) CR2WTypeManager.Create("String", "playthroughId", cr2w, this);
				}
				return _playthroughId;
			}
			set
			{
				if (_playthroughId == value)
				{
					return;
				}
				_playthroughId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("crashVersion")] 
		public CString CrashVersion
		{
			get
			{
				if (_crashVersion == null)
				{
					_crashVersion = (CString) CR2WTypeManager.Create("String", "crashVersion", cr2w, this);
				}
				return _crashVersion;
			}
			set
			{
				if (_crashVersion == value)
				{
					return;
				}
				_crashVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeCrash")] 
		public CString TimeCrash
		{
			get
			{
				if (_timeCrash == null)
				{
					_timeCrash = (CString) CR2WTypeManager.Create("String", "timeCrash", cr2w, this);
				}
				return _timeCrash;
			}
			set
			{
				if (_timeCrash == value)
				{
					return;
				}
				_timeCrash = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("trackedQuest")] 
		public gameTelemetryTrackedQuest TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (gameTelemetryTrackedQuest) CR2WTypeManager.Create("gameTelemetryTrackedQuest", "trackedQuest", cr2w, this);
				}
				return _trackedQuest;
			}
			set
			{
				if (_trackedQuest == value)
				{
					return;
				}
				_trackedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("location")] 
		public Vector3 Location
		{
			get
			{
				if (_location == null)
				{
					_location = (Vector3) CR2WTypeManager.Create("Vector3", "location", cr2w, this);
				}
				return _location;
			}
			set
			{
				if (_location == value)
				{
					return;
				}
				_location = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sessionLength")] 
		public CFloat SessionLength
		{
			get
			{
				if (_sessionLength == null)
				{
					_sessionLength = (CFloat) CR2WTypeManager.Create("Float", "sessionLength", cr2w, this);
				}
				return _sessionLength;
			}
			set
			{
				if (_sessionLength == value)
				{
					return;
				}
				_sessionLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isOom")] 
		public CBool IsOom
		{
			get
			{
				if (_isOom == null)
				{
					_isOom = (CBool) CR2WTypeManager.Create("Bool", "isOom", cr2w, this);
				}
				return _isOom;
			}
			set
			{
				if (_isOom == value)
				{
					return;
				}
				_isOom = value;
				PropertySet(this);
			}
		}

		public gameTelemetryPostMortem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
