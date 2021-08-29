using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetLookState : RedBaseClass
	{
		private EulerAngles _lookDir;

		[Ordinal(0)] 
		[RED("lookDir")] 
		public EulerAngles LookDir
		{
			get => GetProperty(ref _lookDir);
			set => SetProperty(ref _lookDir, value);
		}
	}
}
