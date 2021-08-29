using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopRTTIResourceDumpInfo : RedBaseClass
	{
		private CString _extension;
		private CString _deprecatedExtension;
		private CString _friendlyDescription;

		[Ordinal(0)] 
		[RED("extension")] 
		public CString Extension
		{
			get => GetProperty(ref _extension);
			set => SetProperty(ref _extension, value);
		}

		[Ordinal(1)] 
		[RED("deprecatedExtension")] 
		public CString DeprecatedExtension
		{
			get => GetProperty(ref _deprecatedExtension);
			set => SetProperty(ref _deprecatedExtension, value);
		}

		[Ordinal(2)] 
		[RED("friendlyDescription")] 
		public CString FriendlyDescription
		{
			get => GetProperty(ref _friendlyDescription);
			set => SetProperty(ref _friendlyDescription, value);
		}
	}
}
