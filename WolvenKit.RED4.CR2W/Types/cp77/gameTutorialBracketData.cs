using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTutorialBracketData : CVariable
	{
		private CName _bracketID;
		private CEnum<gameTutorialBracketType> _bracketType;
		private CEnum<inkEAnchor> _anchor;
		private Vector2 _offset;
		private Vector2 _size;

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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public gameTutorialBracketData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
