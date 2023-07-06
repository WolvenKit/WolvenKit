using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetActionContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetPropertyValue<CEnum<gamedeviceRequestType>>();
			set => SetPropertyValue<CEnum<gamedeviceRequestType>>(value);
		}

		public PuppetActionContext()
		{
			RequesterID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
