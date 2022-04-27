using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetBackendData : IBackendData
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<inkWidget> Owner
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("isHiddenInEditor")] 
		public CBool IsHiddenInEditor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("boundLibraryItemName")] 
		public CName BoundLibraryItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkWidgetBackendData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
