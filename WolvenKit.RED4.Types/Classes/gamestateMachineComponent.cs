using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineComponent : gamePlayerControlledComponent
	{
		private CString _packageName;

		[Ordinal(3)] 
		[RED("packageName")] 
		public CString PackageName
		{
			get => GetProperty(ref _packageName);
			set => SetProperty(ref _packageName, value);
		}

		public gamestateMachineComponent()
		{
			_packageName = new() { Text = "playerStateMachine" };
		}
	}
}
