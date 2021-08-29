using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryItemUnpackedView : ISerializable
	{
		private CName _name;
		private CHandle<inkWidgetLibraryItemInstance> _instance;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("instance")] 
		public CHandle<inkWidgetLibraryItemInstance> Instance
		{
			get => GetProperty(ref _instance);
			set => SetProperty(ref _instance, value);
		}
	}
}
