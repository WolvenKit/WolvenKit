using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		private inkCompoundWidgetReference _weaponSpecyficModsRoot;
		private inkWidgetReference _statsWrapper;
		private inkTextWidgetReference _dpsText;
		private inkImageWidgetReference _damageTypeIndicatorImage;
		private inkWidgetReference _dpsWrapper;
		private inkTextWidgetReference _dpsValue;
		private inkWidgetReference _silencerIcon;
		private inkWidgetReference _scopeIcon;
		private inkWidgetReference _dpsArrow;
		private CArray<wCHandle<InventoryItemPartDisplay>> _weaponAttachmentsDisplay;

		[Ordinal(78)] 
		[RED("weaponSpecyficModsRoot")] 
		public inkCompoundWidgetReference WeaponSpecyficModsRoot
		{
			get => GetProperty(ref _weaponSpecyficModsRoot);
			set => SetProperty(ref _weaponSpecyficModsRoot, value);
		}

		[Ordinal(79)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetProperty(ref _statsWrapper);
			set => SetProperty(ref _statsWrapper, value);
		}

		[Ordinal(80)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetProperty(ref _dpsText);
			set => SetProperty(ref _dpsText, value);
		}

		[Ordinal(81)] 
		[RED("damageTypeIndicatorImage")] 
		public inkImageWidgetReference DamageTypeIndicatorImage
		{
			get => GetProperty(ref _damageTypeIndicatorImage);
			set => SetProperty(ref _damageTypeIndicatorImage, value);
		}

		[Ordinal(82)] 
		[RED("dpsWrapper")] 
		public inkWidgetReference DpsWrapper
		{
			get => GetProperty(ref _dpsWrapper);
			set => SetProperty(ref _dpsWrapper, value);
		}

		[Ordinal(83)] 
		[RED("dpsValue")] 
		public inkTextWidgetReference DpsValue
		{
			get => GetProperty(ref _dpsValue);
			set => SetProperty(ref _dpsValue, value);
		}

		[Ordinal(84)] 
		[RED("silencerIcon")] 
		public inkWidgetReference SilencerIcon
		{
			get => GetProperty(ref _silencerIcon);
			set => SetProperty(ref _silencerIcon, value);
		}

		[Ordinal(85)] 
		[RED("scopeIcon")] 
		public inkWidgetReference ScopeIcon
		{
			get => GetProperty(ref _scopeIcon);
			set => SetProperty(ref _scopeIcon, value);
		}

		[Ordinal(86)] 
		[RED("dpsArrow")] 
		public inkWidgetReference DpsArrow
		{
			get => GetProperty(ref _dpsArrow);
			set => SetProperty(ref _dpsArrow, value);
		}

		[Ordinal(87)] 
		[RED("weaponAttachmentsDisplay")] 
		public CArray<wCHandle<InventoryItemPartDisplay>> WeaponAttachmentsDisplay
		{
			get => GetProperty(ref _weaponAttachmentsDisplay);
			set => SetProperty(ref _weaponAttachmentsDisplay, value);
		}

		public InventoryWeaponDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
