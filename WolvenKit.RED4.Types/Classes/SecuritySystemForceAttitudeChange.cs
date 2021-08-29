using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemForceAttitudeChange : ScriptableDeviceAction
	{
		private CName _newAttitude;

		[Ordinal(25)] 
		[RED("newAttitude")] 
		public CName NewAttitude
		{
			get => GetProperty(ref _newAttitude);
			set => SetProperty(ref _newAttitude, value);
		}
	}
}
