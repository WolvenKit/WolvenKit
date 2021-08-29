using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VentilationAreaControllerPS : MasterControllerPS
	{
		private VentilationAreaSetup _ventilationAreaSetup;
		private CBool _isActive;

		[Ordinal(105)] 
		[RED("ventilationAreaSetup")] 
		public VentilationAreaSetup VentilationAreaSetup
		{
			get => GetProperty(ref _ventilationAreaSetup);
			set => SetProperty(ref _ventilationAreaSetup, value);
		}

		[Ordinal(106)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}
	}
}
