using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowBracket_NodeSubType : questITutorial_NodeSubType
	{
		[Ordinal(0)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("bracketType")] 
		public CEnum<gameTutorialBracketType> BracketType
		{
			get => GetPropertyValue<CEnum<gameTutorialBracketType>>();
			set => SetPropertyValue<CEnum<gameTutorialBracketType>>(value);
		}

		[Ordinal(3)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get => GetPropertyValue<CEnum<inkEAnchor>>();
			set => SetPropertyValue<CEnum<inkEAnchor>>(value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(6)] 
		[RED("ignoreDisabledTutorials")] 
		public CBool IgnoreDisabledTutorials
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questShowBracket_NodeSubType()
		{
			Visible = true;
			Offset = new();
			Size = new();
		}
	}
}
