using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryWeaponItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(16)] 
		[RED("scopeRootContainer")] 
		public inkCompoundWidgetReference ScopeRootContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("magazineRootContainer")] 
		public inkCompoundWidgetReference MagazineRootContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("silencerRootContainer")] 
		public inkCompoundWidgetReference SilencerRootContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("scopeContainer")] 
		public inkCompoundWidgetReference ScopeContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("magazineContainer")] 
		public inkCompoundWidgetReference MagazineContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("silencerContainer")] 
		public inkCompoundWidgetReference SilencerContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("attachmentsLabel")] 
		public inkTextWidgetReference AttachmentsLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("attachmentsContainer")] 
		public inkWidgetReference AttachmentsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("softwareModsLabel")] 
		public inkTextWidgetReference SoftwareModsLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("softwareModsPush")] 
		public inkWidgetReference SoftwareModsPush
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("softwareModsContainer")] 
		public inkWidgetReference SoftwareModsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public InventoryWeaponItemChooser()
		{
			ScopeRootContainer = new inkCompoundWidgetReference();
			MagazineRootContainer = new inkCompoundWidgetReference();
			SilencerRootContainer = new inkCompoundWidgetReference();
			ScopeContainer = new inkCompoundWidgetReference();
			MagazineContainer = new inkCompoundWidgetReference();
			SilencerContainer = new inkCompoundWidgetReference();
			AttachmentsLabel = new inkTextWidgetReference();
			AttachmentsContainer = new inkWidgetReference();
			SoftwareModsLabel = new inkTextWidgetReference();
			SoftwareModsPush = new inkWidgetReference();
			SoftwareModsContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
