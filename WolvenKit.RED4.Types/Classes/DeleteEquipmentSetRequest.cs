using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeleteEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		private CString _setName;

		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetProperty(ref _setName);
			set => SetProperty(ref _setName, value);
		}
	}
}
