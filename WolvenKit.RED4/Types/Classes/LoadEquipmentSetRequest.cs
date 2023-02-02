using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LoadEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public LoadEquipmentSetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
