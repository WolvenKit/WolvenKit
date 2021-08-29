using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isActive;
		private gamebbScriptID_Uint32 _playerHealthState;

		[Ordinal(0)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("PlayerHealthState")] 
		public gamebbScriptID_Uint32 PlayerHealthState
		{
			get => GetProperty(ref _playerHealthState);
			set => SetProperty(ref _playerHealthState, value);
		}
	}
}
