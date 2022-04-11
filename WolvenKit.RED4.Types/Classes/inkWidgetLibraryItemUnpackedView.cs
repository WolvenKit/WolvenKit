using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryItemUnpackedView : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("instance")] 
		public CHandle<inkWidgetLibraryItemInstance> Instance
		{
			get => GetPropertyValue<CHandle<inkWidgetLibraryItemInstance>>();
			set => SetPropertyValue<CHandle<inkWidgetLibraryItemInstance>>(value);
		}
	}
}
