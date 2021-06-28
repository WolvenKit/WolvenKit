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
			get => GetProperty(ref _bracketID);
			set => SetProperty(ref _bracketID, value);
		}

		[Ordinal(1)] 
		[RED("bracketType")] 
		public CEnum<gameTutorialBracketType> BracketType
		{
			get => GetProperty(ref _bracketType);
			set => SetProperty(ref _bracketType, value);
		}

		[Ordinal(2)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get => GetProperty(ref _anchor);
			set => SetProperty(ref _anchor, value);
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(4)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		public gameTutorialBracketData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
