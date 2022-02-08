using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("package")] 
		public SharedDataBuffer Package
		{
			get => GetPropertyValue<SharedDataBuffer>();
			set => SetPropertyValue<SharedDataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("packageData")] 
		public DataBuffer PackageData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}
	}
}
