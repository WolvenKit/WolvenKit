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
		[RED("puppetColliderWidget")] 
		public inkWidgetReference PuppetColliderWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("characterCustomizationSystem")] 
		public CWeakHandle<gameuiICharacterCustomizationSystem> CharacterCustomizationSystem
		{
			get => GetPropertyValue<CWeakHandle<gameuiICharacterCustomizationSystem>>();
			set => SetPropertyValue<CWeakHandle<gameuiICharacterCustomizationSystem>>(value);
		}

		[Ordinal(19)] 
		[RED("rotationPanDown")] 
		public CBool RotationPanDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("maxMousePointerOffset")] 
		public CFloat MaxMousePointerOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("mouseRotationSpeed")] 
		public CFloat MouseRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiCharacterCreationPuppetPreviewGameController()
		{
			Root = new inkCompoundWidgetReference();
			Image = new inkImageWidgetReference();
			AnimLib = new inkWidgetLibraryReference();
			PuppetColliderWidget = new inkWidgetReference();
			MaxMousePointerOffset = 100.000000F;
			MouseRotationSpeed = 70.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
