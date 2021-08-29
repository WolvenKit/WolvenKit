using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsKillRewardEvent : redEvent
	{
		private CWeakHandle<gameObject> _victim;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("victim")] 
		public CWeakHandle<gameObject> Victim
		{
			get => GetProperty(ref _victim);
			set => SetProperty(ref _victim, value);
		}

		[Ordinal(1)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetProperty(ref _killType);
			set => SetProperty(ref _killType, value);
		}
	}
}
