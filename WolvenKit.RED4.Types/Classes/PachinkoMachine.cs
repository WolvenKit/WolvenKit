using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PachinkoMachine : ArcadeMachine
	{
		private CName _distractionFXName;

		[Ordinal(104)] 
		[RED("distractionFXName")] 
		public CName DistractionFXName
		{
			get => GetProperty(ref _distractionFXName);
			set => SetProperty(ref _distractionFXName, value);
		}
	}
}
