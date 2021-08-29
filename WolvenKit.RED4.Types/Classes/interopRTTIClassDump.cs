using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopRTTIClassDump : RedBaseClass
	{
		private CArray<CString> _classNames;
		private CArray<CString> _descriptiveNames;
		private CArray<interopRTTIResourceDumpInfo> _resourceInfos;
		private CArray<interopRTTIClassDumpEntry> _entries;

		[Ordinal(0)] 
		[RED("classNames")] 
		public CArray<CString> ClassNames
		{
			get => GetProperty(ref _classNames);
			set => SetProperty(ref _classNames, value);
		}

		[Ordinal(1)] 
		[RED("descriptiveNames")] 
		public CArray<CString> DescriptiveNames
		{
			get => GetProperty(ref _descriptiveNames);
			set => SetProperty(ref _descriptiveNames, value);
		}

		[Ordinal(2)] 
		[RED("resourceInfos")] 
		public CArray<interopRTTIResourceDumpInfo> ResourceInfos
		{
			get => GetProperty(ref _resourceInfos);
			set => SetProperty(ref _resourceInfos, value);
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<interopRTTIClassDumpEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
