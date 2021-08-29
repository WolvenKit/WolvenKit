using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiKillInfo : RedBaseClass
	{
		private CWeakHandle<gameObject> _killerEntity;
		private CWeakHandle<gameObject> _victimEntity;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("killerEntity")] 
		public CWeakHandle<gameObject> KillerEntity
		{
			get => GetProperty(ref _killerEntity);
			set => SetProperty(ref _killerEntity, value);
		}

		[Ordinal(1)] 
		[RED("victimEntity")] 
		public CWeakHandle<gameObject> VictimEntity
		{
			get => GetProperty(ref _victimEntity);
			set => SetProperty(ref _victimEntity, value);
		}

		[Ordinal(2)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetProperty(ref _killType);
			set => SetProperty(ref _killType, value);
		}
	}
}
