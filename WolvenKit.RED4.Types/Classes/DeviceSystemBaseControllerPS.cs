using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceSystemBaseControllerPS : MasterControllerPS
	{
		private CBool _quickHacksEnabled;

		[Ordinal(105)] 
		[RED("quickHacksEnabled")] 
		public CBool QuickHacksEnabled
		{
			get => GetProperty(ref _quickHacksEnabled);
			set => SetProperty(ref _quickHacksEnabled, value);
		}
	}
}
