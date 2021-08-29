using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PullSquadSyncRequest : AIAIEvent
	{
		private CEnum<AISquadType> _squadType;

		[Ordinal(2)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get => GetProperty(ref _squadType);
			set => SetProperty(ref _squadType, value);
		}
	}
}
