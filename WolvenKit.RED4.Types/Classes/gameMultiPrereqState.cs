using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMultiPrereqState : gamePrereqState
	{
		private CArray<CHandle<gamePrereqState>> _nestedStates;

		[Ordinal(0)] 
		[RED("nestedStates")] 
		public CArray<CHandle<gamePrereqState>> NestedStates
		{
			get => GetProperty(ref _nestedStates);
			set => SetProperty(ref _nestedStates, value);
		}
	}
}
