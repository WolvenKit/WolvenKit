using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameOnCarHitPlayer : redEvent
	{
		private Vector4 _hitDirection;
		private entEntityID _carId;

		[Ordinal(0)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(1)] 
		[RED("carId")] 
		public entEntityID CarId
		{
			get => GetProperty(ref _carId);
			set => SetProperty(ref _carId, value);
		}

		public gameOnCarHitPlayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
