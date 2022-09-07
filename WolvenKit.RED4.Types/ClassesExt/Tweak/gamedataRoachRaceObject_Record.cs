
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRoachRaceObject_Record
	{
		[RED("boundingRectangleRelativeArea")]
		[REDProperty(IsIgnored = true)]
		public Vector2 BoundingRectangleRelativeArea
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("position")]
		[REDProperty(IsIgnored = true)]
		public CFloat Position
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("positionRange")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> PositionRange
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("probability")]
		[REDProperty(IsIgnored = true)]
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("score")]
		[REDProperty(IsIgnored = true)]
		public CFloat Score
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawnSFX")]
		[REDProperty(IsIgnored = true)]
		public CName SpawnSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("usingPositionRange")]
		[REDProperty(IsIgnored = true)]
		public CBool UsingPositionRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
