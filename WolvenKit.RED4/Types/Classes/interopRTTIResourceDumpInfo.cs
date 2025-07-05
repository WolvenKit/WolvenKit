using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopRTTIResourceDumpInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("extension")] 
		public CString Extension
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("deprecatedExtension")] 
		public CString DeprecatedExtension
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("friendlyDescription")] 
		public CString FriendlyDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public interopRTTIResourceDumpInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
