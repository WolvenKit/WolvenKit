using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerDescription : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("defaultFluffDescription")] 
		public CString DefaultFluffDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("customDescriptions")] 
		public CArray<CString> CustomDescriptions
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public ScannerDescription()
		{
			CustomDescriptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
