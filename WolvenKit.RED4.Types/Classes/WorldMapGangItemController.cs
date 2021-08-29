using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldMapGangItemController : inkWidgetLogicController
	{
		private inkTextWidgetReference _factionNameText;
		private inkImageWidgetReference _factionIconImage;

		[Ordinal(1)] 
		[RED("factionNameText")] 
		public inkTextWidgetReference FactionNameText
		{
			get => GetProperty(ref _factionNameText);
			set => SetProperty(ref _factionNameText, value);
		}

		[Ordinal(2)] 
		[RED("factionIconImage")] 
		public inkImageWidgetReference FactionIconImage
		{
			get => GetProperty(ref _factionIconImage);
			set => SetProperty(ref _factionIconImage, value);
		}
	}
}
