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
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("iconicLines")] 
		public inkImageWidgetReference IconicLines
		{
			get
			{
				if (_iconicLines == null)
				{
					_iconicLines = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconicLines", cr2w, this);
				}
				return _iconicLines;
			}
			set
			{
				if (_iconicLines == value)
				{
					return;
				}
				_iconicLines = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("iconsNameResolver")] 
		public CHandle<gameuiIconsNameResolver> IconsNameResolver
		{
			get
			{
				if (_iconsNameResolver == null)
				{
					_iconsNameResolver = (CHandle<gameuiIconsNameResolver>) CR2WTypeManager.Create("handle:gameuiIconsNameResolver", "iconsNameResolver", cr2w, this);
				}
				return _iconsNameResolver;
			}
			set
			{
				if (_iconsNameResolver == value)
				{
					return;
				}
				_iconsNameResolver = value;
				PropertySet(this);
			}
		}

		public ItemTooltipIconModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
