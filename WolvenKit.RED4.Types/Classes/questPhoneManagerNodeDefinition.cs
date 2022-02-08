using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPhoneManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIPhoneManagerNodeType> Type
		{
			get => GetPropertyValue<CHandle<questIPhoneManagerNodeType>>();
			set => SetPropertyValue<CHandle<questIPhoneManagerNodeType>>(value);
		}

		public questPhoneManagerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
		}
	}
}
