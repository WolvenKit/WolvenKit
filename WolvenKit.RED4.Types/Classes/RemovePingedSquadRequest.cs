using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemovePingedSquadRequest : gameScriptableSystemRequest
	{
		private CName _squadName;

		[Ordinal(0)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get => GetProperty(ref _squadName);
			set => SetProperty(ref _squadName, value);
		}
	}
}
