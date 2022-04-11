using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddPingedSquadRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
