using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTutorialBracketData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bracketID")] 
		public CName BracketID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("bracketType")] 
		public CEnum<gameTutorialBracketType> BracketType
		{
			get => GetPropertyValue<CEnum<gameTutorialBracketType>>();
			set => SetPropertyValue<CEnum<gameTutorialBracketType>>(value);
		}

		[Ordinal(2)] 
		[RED("anchor")] 
		public CEnum<inkEAnchor> Anchor
		{
			get => GetPropertyValue<CEnum<inkEAnchor>>();
			set => SetPropertyValue<CEnum<inkEAnchor>>(value);
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public Vector2 Offset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(4)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameTutorialBracketData()
		{
			Offset = new Vector2();
			Size = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
