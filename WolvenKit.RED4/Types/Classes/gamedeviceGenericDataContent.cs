using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedeviceGenericDataContent : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("content")] 
		public CArray<gamedeviceDataElement> Content
		{
			get => GetPropertyValue<CArray<gamedeviceDataElement>>();
			set => SetPropertyValue<CArray<gamedeviceDataElement>>(value);
		}

		public gamedeviceGenericDataContent()
		{
			Content = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
