using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnSquadmateDied : redEvent
	{
		private CName _squad;
		private CWeakHandle<entEntity> _squadmate;
		private CWeakHandle<entEntity> _killer;

		[Ordinal(0)] 
		[RED("squad")] 
		public CName Squad
		{
			get => GetProperty(ref _squad);
			set => SetProperty(ref _squad, value);
		}

		[Ordinal(1)] 
		[RED("squadmate")] 
		public CWeakHandle<entEntity> Squadmate
		{
			get => GetProperty(ref _squadmate);
			set => SetProperty(ref _squadmate, value);
		}

		[Ordinal(2)] 
		[RED("killer")] 
		public CWeakHandle<entEntity> Killer
		{
			get => GetProperty(ref _killer);
			set => SetProperty(ref _killer, value);
		}
	}
}
