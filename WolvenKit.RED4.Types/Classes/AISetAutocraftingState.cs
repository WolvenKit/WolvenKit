using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISetAutocraftingState : AIbehaviortaskScript
	{
		private CBool _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CBool NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}
	}
}
