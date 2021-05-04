using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponItemChooser : InventoryGenericItemChooser
	{
		private inkCompoundWidgetReference _scopeRootContainer;
		private inkCompoundWidgetReference _magazineRootContainer;
		private inkCompoundWidgetReference _silencerRootContainer;
		private inkCompoundWidgetReference _scopeContainer;
		private inkCompoundWidgetReference _magazineContainer;
		private inkCompoundWidgetReference _silencerContainer;
		private inkTextWidgetReference _attachmentsLabel;
		private inkWidgetReference _attachmentsContainer;
		private inkTextWidgetReference _softwareModsLabel;
		private inkWidgetReference _softwareModsPush;
		private inkWidgetReference _softwareModsContainer;

		[Ordinal(13)] 
		[RED("scopeRootContainer")] 
		public inkCompoundWidgetReference ScopeRootContainer
		{
			get => GetProperty(ref _scopeRootContainer);
			set => SetProperty(ref _scopeRootContainer, value);
		}

		[Ordinal(14)] 
		[RED("magazineRootContainer")] 
		public inkCompoundWidgetReference MagazineRootContainer
		{
			get => GetProperty(ref _magazineRootContainer);
			set => SetProperty(ref _magazineRootContainer, value);
		}

		[Ordinal(15)] 
		[RED("silencerRootContainer")] 
		public inkCompoundWidgetReference SilencerRootContainer
		{
			get => GetProperty(ref _silencerRootContainer);
			set => SetProperty(ref _silencerRootContainer, value);
		}

		[Ordinal(16)] 
		[RED("scopeContainer")] 
		public inkCompoundWidgetReference ScopeContainer
		{
			get => GetProperty(ref _scopeContainer);
			set => SetProperty(ref _scopeContainer, value);
		}

		[Ordinal(17)] 
		[RED("magazineContainer")] 
		public inkCompoundWidgetReference MagazineContainer
		{
			get => GetProperty(ref _magazineContainer);
			set => SetProperty(ref _magazineContainer, value);
		}

		[Ordinal(18)] 
		[RED("silencerContainer")] 
		public inkCompoundWidgetReference SilencerContainer
		{
			get => GetProperty(ref _silencerContainer);
			set => SetProperty(ref _silencerContainer, value);
		}

		[Ordinal(19)] 
		[RED("attachmentsLabel")] 
		public inkTextWidgetReference AttachmentsLabel
		{
			get => GetProperty(ref _attachmentsLabel);
			set => SetProperty(ref _attachmentsLabel, value);
		}

		[Ordinal(20)] 
		[RED("attachmentsContainer")] 
		public inkWidgetReference AttachmentsContainer
		{
			get => GetProperty(ref _attachmentsContainer);
			set => SetProperty(ref _attachmentsContainer, value);
		}

		[Ordinal(21)] 
		[RED("softwareModsLabel")] 
		public inkTextWidgetReference SoftwareModsLabel
		{
			get => GetProperty(ref _softwareModsLabel);
			set => SetProperty(ref _softwareModsLabel, value);
		}

		[Ordinal(22)] 
		[RED("softwareModsPush")] 
		public inkWidgetReference SoftwareModsPush
		{
			get => GetProperty(ref _softwareModsPush);
			set => SetProperty(ref _softwareModsPush, value);
		}

		[Ordinal(23)] 
		[RED("softwareModsContainer")] 
		public inkWidgetReference SoftwareModsContainer
		{
			get => GetProperty(ref _softwareModsContainer);
			set => SetProperty(ref _softwareModsContainer, value);
		}

		public InventoryWeaponItemChooser(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
