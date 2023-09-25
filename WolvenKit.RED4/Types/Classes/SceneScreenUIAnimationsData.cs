using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SceneScreenUIAnimationsData : IScriptable
	{
		[Ordinal(0)] 
		[RED("customAnimations")] 
		public CHandle<WidgetAnimationManager> CustomAnimations
		{
			get => GetPropertyValue<CHandle<WidgetAnimationManager>>();
			set => SetPropertyValue<CHandle<WidgetAnimationManager>>(value);
		}

		[Ordinal(1)] 
		[RED("onSpawnAnimations")] 
		public CArray<CName> OnSpawnAnimations
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("defaultLibraryItemName")] 
		public CName DefaultLibraryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("defaultLibraryItemAnchor")] 
		public CEnum<inkEAnchor> DefaultLibraryItemAnchor
		{
			get => GetPropertyValue<CEnum<inkEAnchor>>();
			set => SetPropertyValue<CEnum<inkEAnchor>>(value);
		}

		public SceneScreenUIAnimationsData()
		{
			OnSpawnAnimations = new();
			DefaultLibraryItemAnchor = Enums.inkEAnchor.Fill;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
