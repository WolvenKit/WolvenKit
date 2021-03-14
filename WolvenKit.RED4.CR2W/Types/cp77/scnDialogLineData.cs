using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineData : CVariable
	{
		private CRUID _id;
		private CString _text;
		private CEnum<scnDialogLineType> _type;
		private wCHandle<gameObject> _speaker;
		private CString _speakerName;
		private CBool _isPersistent;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CRUID) CR2WTypeManager.Create("CRUID", "id", cr2w, this);
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
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<scnDialogLineType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<scnDialogLineType>) CR2WTypeManager.Create("scnDialogLineType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("speaker")] 
		public wCHandle<gameObject> Speaker
		{
			get
			{
				if (_speaker == null)
				{
					_speaker = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "speaker", cr2w, this);
				}
				return _speaker;
			}
			set
			{
				if (_speaker == value)
				{
					return;
				}
				_speaker = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get
			{
				if (_speakerName == null)
				{
					_speakerName = (CString) CR2WTypeManager.Create("String", "speakerName", cr2w, this);
				}
				return _speakerName;
			}
			set
			{
				if (_speakerName == value)
				{
					return;
				}
				_speakerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get
			{
				if (_isPersistent == null)
				{
					_isPersistent = (CBool) CR2WTypeManager.Create("Bool", "isPersistent", cr2w, this);
				}
				return _isPersistent;
			}
			set
			{
				if (_isPersistent == value)
				{
					return;
				}
				_isPersistent = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		public scnDialogLineData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
