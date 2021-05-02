using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePingEntry : CVariable
	{
		private wCHandle<gameObject> _owner;
		private Vector4 _worldPosition;
		private netTime _time;
		private CEnum<gamedataPingType> _pingType;
		private wCHandle<entEntity> _hitObject;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
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
		public wCHandle<entEntity> HitObject
		{
			get => GetProperty(ref _hitObject);
			set => SetProperty(ref _hitObject, value);
		}

		public gamePingEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
