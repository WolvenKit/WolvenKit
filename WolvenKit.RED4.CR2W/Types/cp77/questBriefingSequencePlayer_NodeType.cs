using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBriefingSequencePlayer_NodeType : questIUIManagerNodeType
	{
		private CEnum<questBriefingSequencePlayerFunction> _function;
		private raRef<inkWidgetLibraryResource> _briefingResource;
		private CHandle<inkUserData> _userData;
		private CName _audioEvent;
		private CName _animationName;
		private CName _startMarkerName;
		private CName _endMarkerName;
		private CEnum<inkanimLoopType> _loopType;
		private CEnum<questBriefingType> _briefingType;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questBriefingSequencePlayerFunction> Function
		{
			get
			{
				if (_function == null)
				{
					_function = (CEnum<questBriefingSequencePlayerFunction>) CR2WTypeManager.Create("questBriefingSequencePlayerFunction", "function", cr2w, this);
				}
				return _function;
			}
			set
			{
				if (_function == value)
				{
					return;
				}
				_function = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("briefingResource")] 
		public raRef<inkWidgetLibraryResource> BriefingResource
		{
			get
			{
				if (_briefingResource == null)
				{
					_briefingResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "briefingResource", cr2w, this);
				}
				return _briefingResource;
			}
			set
			{
				if (_briefingResource == value)
				{
					return;
				}
				_briefingResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<inkUserData> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CHandle<inkUserData>) CR2WTypeManager.Create("handle:inkUserData", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get
			{
				if (_audioEvent == null)
				{
					_audioEvent = (CName) CR2WTypeManager.Create("CName", "audioEvent", cr2w, this);
				}
				return _audioEvent;
			}
			set
			{
				if (_audioEvent == value)
				{
					return;
				}
				_audioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("startMarkerName")] 
		public CName StartMarkerName
		{
			get
			{
				if (_startMarkerName == null)
				{
					_startMarkerName = (CName) CR2WTypeManager.Create("CName", "startMarkerName", cr2w, this);
				}
				return _startMarkerName;
			}
			set
			{
				if (_startMarkerName == value)
				{
					return;
				}
				_startMarkerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("endMarkerName")] 
		public CName EndMarkerName
		{
			get
			{
				if (_endMarkerName == null)
				{
					_endMarkerName = (CName) CR2WTypeManager.Create("CName", "endMarkerName", cr2w, this);
				}
				return _endMarkerName;
			}
			set
			{
				if (_endMarkerName == value)
				{
					return;
				}
				_endMarkerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get
			{
				if (_loopType == null)
				{
					_loopType = (CEnum<inkanimLoopType>) CR2WTypeManager.Create("inkanimLoopType", "loopType", cr2w, this);
				}
				return _loopType;
			}
			set
			{
				if (_loopType == value)
				{
					return;
				}
				_loopType = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("briefingType")] 
		public CEnum<questBriefingType> BriefingType
		{
			get
			{
				if (_briefingType == null)
				{
					_briefingType = (CEnum<questBriefingType>) CR2WTypeManager.Create("questBriefingType", "briefingType", cr2w, this);
				}
				return _briefingType;
			}
			set
			{
				if (_briefingType == value)
				{
					return;
				}
				_briefingType = value;
				PropertySet(this);
			}
		}

		public questBriefingSequencePlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
