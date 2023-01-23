using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SCyberware : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cyberwareName")] 
		public CString CyberwareName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("cyberWareTier")] 
		public CInt32 CyberWareTier
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("loc_name_key")] 
		public CString Loc_name_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("loc_desc_key")] 
		public CString Loc_desc_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SCyberware()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
