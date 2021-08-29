using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AOEAreaControllerPS : MasterControllerPS
	{
		private AOEAreaSetup _aOEAreaSetup;

		[Ordinal(105)] 
		[RED("AOEAreaSetup")] 
		public AOEAreaSetup AOEAreaSetup
		{
			get => GetProperty(ref _aOEAreaSetup);
			set => SetProperty(ref _aOEAreaSetup, value);
		}
	}
}
