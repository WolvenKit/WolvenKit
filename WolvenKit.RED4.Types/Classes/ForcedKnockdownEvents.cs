using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForcedKnockdownEvents : KnockdownEvents
	{
		private CBool _firstUpdate;

		[Ordinal(13)] 
		[RED("firstUpdate")] 
		public CBool FirstUpdate
		{
			get => GetProperty(ref _firstUpdate);
			set => SetProperty(ref _firstUpdate, value);
		}
	}
}
