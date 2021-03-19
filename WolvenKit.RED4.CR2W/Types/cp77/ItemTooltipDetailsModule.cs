using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipDetailsModule : ItemTooltipModuleController
	{
		private inkWidgetReference _statsLine;
		private inkWidgetReference _statsWrapper;
		private inkCompoundWidgetReference _statsContainer;
		private inkWidgetReference _dedicatedModsLine;
		private inkWidgetReference _dedicatedModsWrapper;
		private inkCompoundWidgetReference _dedicatedModsContainer;
		private inkWidgetReference _modsLine;
		private inkWidgetReference _modsWrapper;
		private inkCompoundWidgetReference _modsContainer;

		[Ordinal(2)] 
		[RED("statsLine")] 
		public inkWidgetReference StatsLine
		{
			get => GetProperty(ref _statsLine);
			set => SetProperty(ref _statsLine, value);
		}

		[Ordinal(3)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetProperty(ref _statsWrapper);
			set => SetProperty(ref _statsWrapper, value);
		}

		[Ordinal(4)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetProperty(ref _statsContainer);
			set => SetProperty(ref _statsContainer, value);
		}

		[Ordinal(5)] 
		[RED("dedicatedModsLine")] 
		public inkWidgetReference DedicatedModsLine
		{
			get => GetProperty(ref _dedicatedModsLine);
			set => SetProperty(ref _dedicatedModsLine, value);
		}

		[Ordinal(6)] 
		[RED("dedicatedModsWrapper")] 
		public inkWidgetReference DedicatedModsWrapper
		{
			get => GetProperty(ref _dedicatedModsWrapper);
			set => SetProperty(ref _dedicatedModsWrapper, value);
		}

		[Ordinal(7)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get => GetProperty(ref _dedicatedModsContainer);
			set => SetProperty(ref _dedicatedModsContainer, value);
		}

		[Ordinal(8)] 
		[RED("modsLine")] 
		public inkWidgetReference ModsLine
		{
			get => GetProperty(ref _modsLine);
			set => SetProperty(ref _modsLine, value);
		}

		[Ordinal(9)] 
		[RED("modsWrapper")] 
		public inkWidgetReference ModsWrapper
		{
			get => GetProperty(ref _modsWrapper);
			set => SetProperty(ref _modsWrapper, value);
		}

		[Ordinal(10)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get => GetProperty(ref _modsContainer);
			set => SetProperty(ref _modsContainer, value);
		}

		public ItemTooltipDetailsModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
