using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeHalfLights : redEvent
	{
		private CBool _isAuthorization;

		[Ordinal(0)] 
		[RED("isAuthorization")] 
		public CBool IsAuthorization
		{
			get => GetProperty(ref _isAuthorization);
			set => SetProperty(ref _isAuthorization, value);
		}
	}
}
