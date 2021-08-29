using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePingEntry : RedBaseClass
	{
		private CWeakHandle<gameObject> _owner;
		private Vector4 _worldPosition;
		private netTime _time;
		private CEnum<gamedataPingType> _pingType;
		private CWeakHandle<entEntity> _hitObject;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get => GetProperty(ref _worldPosition);
			set => SetProperty(ref _worldPosition, value);
		}

		[Ordinal(2)] 
		[RED("time")] 
		public netTime Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(3)] 
		[RED("pingType")] 
		public CEnum<gamedataPingType> PingType
		{
			get => GetProperty(ref _pingType);
			set => SetProperty(ref _pingType, value);
		}

		[Ordinal(4)] 
		[RED("hitObject")] 
		public CWeakHandle<entEntity> HitObject
		{
			get => GetProperty(ref _hitObject);
			set => SetProperty(ref _hitObject, value);
		}
	}
}
