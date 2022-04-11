using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeleteEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
