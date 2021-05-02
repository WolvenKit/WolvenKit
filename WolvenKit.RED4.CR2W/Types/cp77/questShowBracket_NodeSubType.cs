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
			get => GetProperty(ref _bracketID);
			set => SetProperty(ref _bracketID, value);
		}

		[Ordinal(1)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(2)] 
		[RED("bracketType")] 
		public CEnum<gameTutorialBracketType> BracketType
		{
			get => GetProperty(ref _bracketType);
			set => SetProperty(ref _bracketType, value);
		}

		[Ordinal(3)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get => GetProperty(ref _anchor);
			set => SetProperty(ref _anchor, value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(5)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(6)] 
		[RED("ignoreDisabledTutorials")] 
		public CBool IgnoreDisabledTutorials
		{
			get => GetProperty(ref _ignoreDisabledTutorials);
			set => SetProperty(ref _ignoreDisabledTutorials, value);
		}

		public questShowBracket_NodeSubType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
