using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipIconModule : ItemTooltipModuleController
	{
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _iconicLines;
		private CHandle<gameuiIconsNameResolver> _iconsNameResolver;

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("iconicLines")] 
		public inkImageWidgetReference IconicLines
		{
			get => GetProperty(ref _iconicLines);
			set => SetProperty(ref _iconicLines, value);
		}

		[Ordinal(4)] 
		[RED("iconsNameResolver")] 
		public CHandle<gameuiIconsNameResolver> IconsNameResolver
		{
			get => GetProperty(ref _iconsNameResolver);
			set => SetProperty(ref _iconsNameResolver, value);
		}

		public ItemTooltipIconModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
