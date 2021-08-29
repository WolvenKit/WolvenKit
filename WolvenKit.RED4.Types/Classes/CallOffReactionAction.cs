using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CallOffReactionAction : SquadTask
	{
		private CEnum<EAISquadAction> _squadActionName;

		[Ordinal(0)] 
		[RED("squadActionName")] 
		public CEnum<EAISquadAction> SquadActionName
		{
			get => GetProperty(ref _squadActionName);
			set => SetProperty(ref _squadActionName, value);
		}
	}
}
