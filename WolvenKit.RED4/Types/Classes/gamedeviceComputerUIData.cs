using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedeviceComputerUIData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mails")] 
		public CArray<gamedeviceGenericDataContent> Mails
		{
			get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
			set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
		}

		[Ordinal(1)] 
		[RED("files")] 
		public CArray<gamedeviceGenericDataContent> Files
		{
			get => GetPropertyValue<CArray<gamedeviceGenericDataContent>>();
			set => SetPropertyValue<CArray<gamedeviceGenericDataContent>>(value);
		}

		public gamedeviceComputerUIData()
		{
			Mails = new();
			Files = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
