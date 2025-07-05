using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCreationPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		[Ordinal(9)] 
		[RED("maleSceneName")] 
		public CName MaleSceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("femaleSceneName")] 
		public CName FemaleSceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("maleCamera01Ref")] 
		public NodeRef MaleCamera01Ref
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(12)] 
		[RED("femaleCamera01Ref")] 
		public NodeRef FemaleCamera01Ref
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(13)] 
		[RED("root")] 
		public inkCompoundWidgetReference Root
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("animLib")] 
		public inkWidgetLibraryReference AnimLib
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(16)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("characterCustomizationSystem")] 
		public CWeakHandle<gameuiICharacterCustomizationSystem> CharacterCustomizationSystem
		{
			get => GetPropertyValue<CWeakHandle<gameuiICharacterCustomizationSystem>>();
			set => SetPropertyValue<CWeakHandle<gameuiICharacterCustomizationSystem>>(value);
		}

		public gameuiCharacterCreationPuppetPreviewGameController()
		{
			Root = new inkCompoundWidgetReference();
			Image = new inkImageWidgetReference();
			AnimLib = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
