using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterNetworkLinksByIdAndTypeRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public entEntityID ID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<ELinkType> Type
		{
			get => GetPropertyValue<CEnum<ELinkType>>();
			set => SetPropertyValue<CEnum<ELinkType>>(value);
		}

		public UnregisterNetworkLinksByIdAndTypeRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
