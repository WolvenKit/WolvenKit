using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForkliftControllerPS : ScriptableDeviceComponentPS
	{
		private ForkliftSetup _forkliftSetup;
		private CBool _isUp;

		[Ordinal(104)] 
		[RED("forkliftSetup")] 
		public ForkliftSetup ForkliftSetup
		{
			get => GetProperty(ref _forkliftSetup);
			set => SetProperty(ref _forkliftSetup, value);
		}

		[Ordinal(105)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get => GetProperty(ref _isUp);
			set => SetProperty(ref _isUp, value);
		}
	}
}
