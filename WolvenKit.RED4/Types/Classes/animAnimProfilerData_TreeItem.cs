using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimProfilerData_TreeItem : ISerializable
	{
		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("exclusiveTimeMS")] 
		public CFloat ExclusiveTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("inclusiveTimeMS")] 
		public CFloat InclusiveTimeMS
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CHandle<animAnimProfilerData_TreeItem>> Children
		{
			get => GetPropertyValue<CArray<CHandle<animAnimProfilerData_TreeItem>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimProfilerData_TreeItem>>>(value);
		}

		public animAnimProfilerData_TreeItem()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
