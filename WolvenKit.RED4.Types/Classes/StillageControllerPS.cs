using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StillageControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isCleared;

		[Ordinal(104)] 
		[RED("isCleared")] 
		public CBool IsCleared
		{
			get => GetProperty(ref _isCleared);
			set => SetProperty(ref _isCleared, value);
		}
	}
}
