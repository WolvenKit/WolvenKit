using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopRTTIClassDump : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("classNames")] 
		public CArray<CString> ClassNames
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(1)] 
		[RED("descriptiveNames")] 
		public CArray<CString> DescriptiveNames
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(2)] 
		[RED("resourceInfos")] 
		public CArray<interopRTTIResourceDumpInfo> ResourceInfos
		{
			get => GetPropertyValue<CArray<interopRTTIResourceDumpInfo>>();
			set => SetPropertyValue<CArray<interopRTTIResourceDumpInfo>>(value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<interopRTTIClassDumpEntry> Entries
		{
			get => GetPropertyValue<CArray<interopRTTIClassDumpEntry>>();
			set => SetPropertyValue<CArray<interopRTTIClassDumpEntry>>(value);
		}

		public interopRTTIClassDump()
		{
			ClassNames = new();
			DescriptiveNames = new();
			ResourceInfos = new();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
