using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityToAppearancesAndColorVariantsMapEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CString DebugEntityPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("appearancesAndTheirColorVariants")] 
		public CArray<gameEntityAppearanceColorVariantsArray> AppearancesAndTheirColorVariants
		{
			get => GetPropertyValue<CArray<gameEntityAppearanceColorVariantsArray>>();
			set => SetPropertyValue<CArray<gameEntityAppearanceColorVariantsArray>>(value);
		}

		public gameEntityToAppearancesAndColorVariantsMapEntry()
		{
			AppearancesAndTheirColorVariants = new();
		}
	}
}
