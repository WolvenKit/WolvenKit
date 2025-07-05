
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRoachRaceObstacleTexturePartPair_Record
	{
		[RED("imageTexturePart")]
		[REDProperty(IsIgnored = true)]
		public CName ImageTexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
