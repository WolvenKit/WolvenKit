using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedebugFailure : ISerializable
	{
		private gamedebugFailureId _id;
		private CFloat _time;
		private CString _message;
		private gameDebugPath _path;
		private CHandle<gamedebugFailure> _previous;
		private CHandle<gamedebugFailure> _cause;

		[Ordinal(0)] 
		[RED("id")] 
		public gamedebugFailureId Id
		{
			get
			{
				if (_id == null)
				{
					_id = (gamedebugFailureId) CR2WTypeManager.Create("gamedebugFailureId", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get
			{
				if (_message == null)
				{
					_message = (CString) CR2WTypeManager.Create("String", "message", cr2w, this);
				}
				return _message;
			}
			set
			{
				if (_message == value)
				{
					return;
				}
				_message = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("path")] 
		public gameDebugPath Path
		{
			get
			{
				if (_path == null)
				{
					_path = (gameDebugPath) CR2WTypeManager.Create("gameDebugPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("previous")] 
		public CHandle<gamedebugFailure> Previous
		{
			get
			{
				if (_previous == null)
				{
					_previous = (CHandle<gamedebugFailure>) CR2WTypeManager.Create("handle:gamedebugFailure", "previous", cr2w, this);
				}
				return _previous;
			}
			set
			{
				if (_previous == value)
				{
					return;
				}
				_previous = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cause")] 
		public CHandle<gamedebugFailure> Cause
		{
			get
			{
				if (_cause == null)
				{
					_cause = (CHandle<gamedebugFailure>) CR2WTypeManager.Create("handle:gamedebugFailure", "cause", cr2w, this);
				}
				return _cause;
			}
			set
			{
				if (_cause == value)
				{
					return;
				}
				_cause = value;
				PropertySet(this);
			}
		}

		public gamedebugFailure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
