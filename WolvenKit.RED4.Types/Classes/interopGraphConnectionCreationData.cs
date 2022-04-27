using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopGraphConnectionCreationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CString Data
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("extraData")] 
		public CArray<CString> ExtraData
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public interopGraphConnectionCreationData()
		{
			ExtraData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
