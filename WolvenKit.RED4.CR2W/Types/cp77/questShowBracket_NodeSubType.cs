using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowBracket_NodeSubType : questITutorial_NodeSubType
	{
		private CName _bracketID;
		private CBool _visible;
		private CEnum<gameTutorialBracketType> _bracketType;
		private CEnum<inkEAnchor> _anchor;
		private Vector2 _offset;
		private Vector2 _size;
		private CBool _ignoreDisabledTutorials;

		[Ordinal(0)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get
			{
				if (_bracketID == null)
				{
					_bracketID = (CName) CR2WTypeManager.Create("CName", "bracketID", cr2w, this);
				}
				return _bracketID;
			}
			set
			{
				if (_bracketID == value)
				{
					return;
				}
				_bracketID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visible")] 
		public CBool Visible
		{
			get
			{
				if (_visible == null)
				{
					_visible = (CBool) CR2WTypeManager.Create("Bool", "visible", cr2w, this);
				}
				return _visible;
			}
			set
			{
				if (_visible == value)
				{
					return;
				}
				_visible = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bracketType")] 
		public CEnum<gameTutorialBracketType> BracketType
		{
			get
			{
				if (_bracketType == null)
				{
					_bracketType = (CEnum<gameTutorialBracketType>) CR2WTypeManager.Create("gameTutorialBracketType", "bracketType", cr2w, this);
				}
				return _bracketType;
			}
			set
			{
				if (_bracketType == value)
				{
					return;
				}
				_bracketType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get
			{
				if (_anchor == null)
				{
					_anchor = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "anchor", cr2w, this);
				}
				return _anchor;
			}
			set
			{
				if (_anchor == value)
				{
					return;
				}
				_anchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector2) CR2WTypeManager.Create("Vector2", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("size")] 
		public Vector2 Size
		{
			get
			{
				if (_size == null)
				{
					_size = (Vector2) CR2WTypeManager.Create("Vector2", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ignoreDisabledTutorials")] 
		public CBool IgnoreDisabledTutorials
		{
			get
			{
				if (_ignoreDisabledTutorials == null)
				{
					_ignoreDisabledTutorials = (CBool) CR2WTypeManager.Create("Bool", "ignoreDisabledTutorials", cr2w, this);
				}
				return _ignoreDisabledTutorials;
			}
			set
			{
				if (_ignoreDisabledTutorials == value)
				{
					return;
				}
				_ignoreDisabledTutorials = value;
				PropertySet(this);
			}
		}

		public questShowBracket_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
