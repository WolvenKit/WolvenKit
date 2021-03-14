using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsEntry : CVariable
	{
		private scnSceneEventId _eventId;
		private CName _startName;
		private CName _endName;
		private CName _startDisplayName;
		private CName _endDisplayName;
		private Vector4 _startPos;
		private Vector4 _endPos;
		private Vector4 _startDir;
		private Vector4 _endDir;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("eventId")] 
		public scnSceneEventId EventId
		{
			get
			{
				if (_eventId == null)
				{
					_eventId = (scnSceneEventId) CR2WTypeManager.Create("scnSceneEventId", "eventId", cr2w, this);
				}
				return _eventId;
			}
			set
			{
				if (_eventId == value)
				{
					return;
				}
				_eventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startName")] 
		public CName StartName
		{
			get
			{
				if (_startName == null)
				{
					_startName = (CName) CR2WTypeManager.Create("CName", "startName", cr2w, this);
				}
				return _startName;
			}
			set
			{
				if (_startName == value)
				{
					return;
				}
				_startName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("endName")] 
		public CName EndName
		{
			get
			{
				if (_endName == null)
				{
					_endName = (CName) CR2WTypeManager.Create("CName", "endName", cr2w, this);
				}
				return _endName;
			}
			set
			{
				if (_endName == value)
				{
					return;
				}
				_endName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("startDisplayName")] 
		public CName StartDisplayName
		{
			get
			{
				if (_startDisplayName == null)
				{
					_startDisplayName = (CName) CR2WTypeManager.Create("CName", "startDisplayName", cr2w, this);
				}
				return _startDisplayName;
			}
			set
			{
				if (_startDisplayName == value)
				{
					return;
				}
				_startDisplayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("endDisplayName")] 
		public CName EndDisplayName
		{
			get
			{
				if (_endDisplayName == null)
				{
					_endDisplayName = (CName) CR2WTypeManager.Create("CName", "endDisplayName", cr2w, this);
				}
				return _endDisplayName;
			}
			set
			{
				if (_endDisplayName == value)
				{
					return;
				}
				_endDisplayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("startPos")] 
		public Vector4 StartPos
		{
			get
			{
				if (_startPos == null)
				{
					_startPos = (Vector4) CR2WTypeManager.Create("Vector4", "startPos", cr2w, this);
				}
				return _startPos;
			}
			set
			{
				if (_startPos == value)
				{
					return;
				}
				_startPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("endPos")] 
		public Vector4 EndPos
		{
			get
			{
				if (_endPos == null)
				{
					_endPos = (Vector4) CR2WTypeManager.Create("Vector4", "endPos", cr2w, this);
				}
				return _endPos;
			}
			set
			{
				if (_endPos == value)
				{
					return;
				}
				_endPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("startDir")] 
		public Vector4 StartDir
		{
			get
			{
				if (_startDir == null)
				{
					_startDir = (Vector4) CR2WTypeManager.Create("Vector4", "startDir", cr2w, this);
				}
				return _startDir;
			}
			set
			{
				if (_startDir == value)
				{
					return;
				}
				_startDir = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("endDir")] 
		public Vector4 EndDir
		{
			get
			{
				if (_endDir == null)
				{
					_endDir = (Vector4) CR2WTypeManager.Create("Vector4", "endDir", cr2w, this);
				}
				return _endDir;
			}
			set
			{
				if (_endDir == value)
				{
					return;
				}
				_endDir = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt8) CR2WTypeManager.Create("Uint8", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public scnSceneMarkerInternalsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
