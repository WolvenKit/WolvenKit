using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLatestSaveMetadataInfo : IScriptable
	{
		private CString _locationName;
		private CString _trackedQuest;
		private CEnum<inkLifePath> _lifePath;
		private CDouble _playTime;
		private CDouble _playthroughTime;

		[Ordinal(0)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get
			{
				if (_locationName == null)
				{
					_locationName = (CString) CR2WTypeManager.Create("String", "locationName", cr2w, this);
				}
				return _locationName;
			}
			set
			{
				if (_locationName == value)
				{
					return;
				}
				_locationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (CString) CR2WTypeManager.Create("String", "trackedQuest", cr2w, this);
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

		[Ordinal(2)] 
		[RED("lifePath")] 
		public CEnum<inkLifePath> LifePath
		{
			get
			{
				if (_lifePath == null)
				{
					_lifePath = (CEnum<inkLifePath>) CR2WTypeManager.Create("inkLifePath", "lifePath", cr2w, this);
				}
				return _lifePath;
			}
			set
			{
				if (_lifePath == value)
				{
					return;
				}
				_lifePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get
			{
				if (_playTime == null)
				{
					_playTime = (CDouble) CR2WTypeManager.Create("Double", "playTime", cr2w, this);
				}
				return _playTime;
			}
			set
			{
				if (_playTime == value)
				{
					return;
				}
				_playTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get
			{
				if (_playthroughTime == null)
				{
					_playthroughTime = (CDouble) CR2WTypeManager.Create("Double", "playthroughTime", cr2w, this);
				}
				return _playthroughTime;
			}
			set
			{
				if (_playthroughTime == value)
				{
					return;
				}
				_playthroughTime = value;
				PropertySet(this);
			}
		}

		public inkLatestSaveMetadataInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
