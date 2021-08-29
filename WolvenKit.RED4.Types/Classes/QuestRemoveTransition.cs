using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestRemoveTransition : redEvent
	{
		private CInt32 _removeTransitionFrom;

		[Ordinal(0)] 
		[RED("removeTransitionFrom")] 
		public CInt32 RemoveTransitionFrom
		{
			get => GetProperty(ref _removeTransitionFrom);
			set => SetProperty(ref _removeTransitionFrom, value);
		}
	}
}
