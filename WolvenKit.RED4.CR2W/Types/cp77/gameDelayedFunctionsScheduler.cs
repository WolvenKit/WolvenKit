using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDelayedFunctionsScheduler : ISerializable
	{
		private CBool _initialized;
		private EngineTime _currentTime;
		private CUInt32 _nextCallId;

		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get
			{
				if (_initialized == null)
				{
					_initialized = (CBool) CR2WTypeManager.Create("Bool", "initialized", cr2w, this);
				}
				return _initialized;
			}
			set
			{
				if (_initialized == value)
				{
					return;
				}
				_initialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentTime")] 
		public EngineTime CurrentTime
		{
			get
			{
				if (_currentTime == null)
				{
					_currentTime = (EngineTime) CR2WTypeManager.Create("EngineTime", "currentTime", cr2w, this);
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
		[RED("nextCallId")] 
		public CUInt32 NextCallId
		{
			get
			{
				if (_nextCallId == null)
				{
					_nextCallId = (CUInt32) CR2WTypeManager.Create("Uint32", "nextCallId", cr2w, this);
				}
				return _nextCallId;
			}
			set
			{
				if (_nextCallId == value)
				{
					return;
				}
				_nextCallId = value;
				PropertySet(this);
			}
		}

		public gameDelayedFunctionsScheduler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
