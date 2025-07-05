using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimProfileData_RootItem : ISerializable
	{
		[Ordinal(0)] 
		[RED("timeMS")] 
		public CFloat TimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("children")] 
		public CArray<CHandle<animAnimProfilerData_TreeItem>> Children
		{
			get => GetPropertyValue<CArray<CHandle<animAnimProfilerData_TreeItem>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimProfilerData_TreeItem>>>(value);
		}

		public animAnimProfileData_RootItem()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
