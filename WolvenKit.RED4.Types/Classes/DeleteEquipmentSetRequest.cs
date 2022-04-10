using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeleteEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public DeleteEquipmentSetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
