using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidTag : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("signature")] 
		public CName Signature
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("serialNumber")] 
		public scnRidSerialNumber SerialNumber
		{
			get => GetPropertyValue<scnRidSerialNumber>();
			set => SetPropertyValue<scnRidSerialNumber>(value);
		}

		public scnRidTag()
		{
			SerialNumber = new() { SerialNumber = 4294967295 };
		}
	}
}
