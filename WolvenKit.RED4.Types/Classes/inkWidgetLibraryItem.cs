using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryItem : RedBaseClass
	{
		private CName _name;
		private SharedDataBuffer _package;
		private DataBuffer _packageData;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("package")] 
		public SharedDataBuffer Package
		{
			get => GetProperty(ref _package);
			set => SetProperty(ref _package, value);
		}

		[Ordinal(2)] 
		[RED("packageData")] 
		public DataBuffer PackageData
		{
			get => GetProperty(ref _packageData);
			set => SetProperty(ref _packageData, value);
		}
	}
}
