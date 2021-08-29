using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerTargetChangedRequest : gameScriptableSystemRequest
	{
		private entEntityID _playerTarget;

		[Ordinal(0)] 
		[RED("playerTarget")] 
		public entEntityID PlayerTarget
		{
			get => GetProperty(ref _playerTarget);
			set => SetProperty(ref _playerTarget, value);
		}
	}
}
