using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSetAsQuestImportantEvent : redEvent
	{
		private CBool _isImportant;
		private CBool _propagateToSlaves;

		[Ordinal(0)] 
		[RED("isImportant")] 
		public CBool IsImportant
		{
			get => GetProperty(ref _isImportant);
			set => SetProperty(ref _isImportant, value);
		}

		[Ordinal(1)] 
		[RED("propagateToSlaves")] 
		public CBool PropagateToSlaves
		{
			get => GetProperty(ref _propagateToSlaves);
			set => SetProperty(ref _propagateToSlaves, value);
		}
	}
}
