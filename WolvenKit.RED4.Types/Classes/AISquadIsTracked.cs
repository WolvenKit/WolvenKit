using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISquadIsTracked : AIAIEvent
	{
		private CBool _isSquadTracked;

		[Ordinal(2)] 
		[RED("isSquadTracked")] 
		public CBool IsSquadTracked
		{
			get => GetProperty(ref _isSquadTracked);
			set => SetProperty(ref _isSquadTracked, value);
		}
	}
}
