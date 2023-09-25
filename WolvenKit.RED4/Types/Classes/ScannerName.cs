using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerName : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("hasArchetype")] 
		public CBool HasArchetype
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		public ScannerName()
		{
			DisplayName = "LocKey#42211";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
