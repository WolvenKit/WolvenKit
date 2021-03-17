using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapDistrictTooltipController : WorldMapTooltipBaseController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _levelRangeText;
		private inkTextWidgetReference _threatText;
		private inkTextWidgetReference _completionText;
		private inkWidgetReference _gangsContainer;
		private inkCompoundWidgetReference _gangsList;
		private CArray<wCHandle<WorldMapGangItemController>> _gangControllers;

		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(6)] 
		[RED("levelRangeText")] 
		public inkTextWidgetReference LevelRangeText
		{
			get => GetProperty(ref _levelRangeText);
			set => SetProperty(ref _levelRangeText, value);
		}

		[Ordinal(7)] 
		[RED("threatText")] 
		public inkTextWidgetReference ThreatText
		{
			get => GetProperty(ref _threatText);
			set => SetProperty(ref _threatText, value);
		}

		[Ordinal(8)] 
		[RED("completionText")] 
		public inkTextWidgetReference CompletionText
		{
			get => GetProperty(ref _completionText);
			set => SetProperty(ref _completionText, value);
		}

		[Ordinal(9)] 
		[RED("gangsContainer")] 
		public inkWidgetReference GangsContainer
		{
			get => GetProperty(ref _gangsContainer);
			set => SetProperty(ref _gangsContainer, value);
		}

		[Ordinal(10)] 
		[RED("gangsList")] 
		public inkCompoundWidgetReference GangsList
		{
			get => GetProperty(ref _gangsList);
			set => SetProperty(ref _gangsList, value);
		}

		[Ordinal(11)] 
		[RED("gangControllers")] 
		public CArray<wCHandle<WorldMapGangItemController>> GangControllers
		{
			get => GetProperty(ref _gangControllers);
			set => SetProperty(ref _gangControllers, value);
		}

		public WorldMapDistrictTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
