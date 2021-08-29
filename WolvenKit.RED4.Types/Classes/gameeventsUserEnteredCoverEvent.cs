using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsUserEnteredCoverEvent : redEvent
	{
		private CArray<WorldTransform> _actionsPoints;

		[Ordinal(0)] 
		[RED("actionsPoints")] 
		public CArray<WorldTransform> ActionsPoints
		{
			get => GetProperty(ref _actionsPoints);
			set => SetProperty(ref _actionsPoints, value);
		}
	}
}
