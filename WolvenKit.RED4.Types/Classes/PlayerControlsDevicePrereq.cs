using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerControlsDevicePrereq : gameIScriptablePrereq
	{
		private CBool _inverse;

		[Ordinal(0)] 
		[RED("inverse")] 
		public CBool Inverse
		{
			get => GetProperty(ref _inverse);
			set => SetProperty(ref _inverse, value);
		}

		public PlayerControlsDevicePrereq()
		{
			_inverse = true;
		}
	}
}
