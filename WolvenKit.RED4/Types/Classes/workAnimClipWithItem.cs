using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workAnimClipWithItem : workAnimClip
	{
		[Ordinal(4)] 
		[RED("itemActions")] 
		public CArray<CHandle<workIWorkspotItemAction>> ItemActions
		{
			get => GetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>();
			set => SetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>(value);
		}

		public workAnimClipWithItem()
		{
			Flags = 8194;
			ItemActions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
