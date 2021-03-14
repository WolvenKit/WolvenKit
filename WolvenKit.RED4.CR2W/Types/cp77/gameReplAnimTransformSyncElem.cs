using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformSyncElem : CVariable
	{
		private CInt32 _definitionId;
		private CFloat _currentTime;
		private CFloat _timeScale;
		private CFloat _duration;
		private CInt32 _timesToPlay;
		private CBool _playing;

		[Ordinal(0)] 
		[RED("definitionId")] 
		public CInt32 DefinitionId
		{
			get
			{
				if (_definitionId == null)
				{
					_definitionId = (CInt32) CR2WTypeManager.Create("Int32", "definitionId", cr2w, this);
				}
				return _definitionId;
			}
			set
			{
				if (_definitionId == value)
				{
					return;
				}
				_definitionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get
			{
				if (_currentTime == null)
				{
					_currentTime = (CFloat) CR2WTypeManager.Create("Float", "currentTime", cr2w, this);
				}
				return _currentTime;
			}
			set
			{
				if (_currentTime == value)
				{
					return;
				}
				_currentTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get
			{
				if (_timeScale == null)
				{
					_timeScale = (CFloat) CR2WTypeManager.Create("Float", "timeScale", cr2w, this);
				}
				return _timeScale;
			}
			set
			{
				if (_timeScale == value)
				{
					return;
				}
				_timeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timesToPlay")] 
		public CInt32 TimesToPlay
		{
			get
			{
				if (_timesToPlay == null)
				{
					_timesToPlay = (CInt32) CR2WTypeManager.Create("Int32", "timesToPlay", cr2w, this);
				}
				return _timesToPlay;
			}
			set
			{
				if (_timesToPlay == value)
				{
					return;
				}
				_timesToPlay = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("playing")] 
		public CBool Playing
		{
			get
			{
				if (_playing == null)
				{
					_playing = (CBool) CR2WTypeManager.Create("Bool", "playing", cr2w, this);
				}
				return _playing;
			}
			set
			{
				if (_playing == value)
				{
					return;
				}
				_playing = value;
				PropertySet(this);
			}
		}

		public gameReplAnimTransformSyncElem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
