using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionSecurityAreaRequest : gameScriptableSystemRequest
	{
		private CBool _playerIsIn;
		private gamePersistentID _areaID;

		[Ordinal(0)] 
		[RED("playerIsIn")] 
		public CBool PlayerIsIn
		{
			get => GetProperty(ref _playerIsIn);
			set => SetProperty(ref _playerIsIn, value);
		}

		[Ordinal(1)] 
		[RED("areaID")] 
		public gamePersistentID AreaID
		{
			get => GetProperty(ref _areaID);
			set => SetProperty(ref _areaID, value);
		}
	}
}
