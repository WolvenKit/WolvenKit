using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIHostJoinedSquad : AIAIEvent
	{
		private CName _squad;

		[Ordinal(2)] 
		[RED("squad")] 
		public CName Squad
		{
			get => GetProperty(ref _squad);
			set => SetProperty(ref _squad, value);
		}
	}
}
