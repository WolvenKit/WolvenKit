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
			get
			{
				if (_hitDirection == null)
				{
					_hitDirection = (Vector4) CR2WTypeManager.Create("Vector4", "hitDirection", cr2w, this);
				}
				return _hitDirection;
			}
			set
			{
				if (_hitDirection == value)
				{
					return;
				}
				_hitDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("carId")] 
		public entEntityID CarId
		{
			get
			{
				if (_carId == null)
				{
					_carId = (entEntityID) CR2WTypeManager.Create("entEntityID", "carId", cr2w, this);
				}
				return _carId;
			}
			set
			{
				if (_carId == value)
				{
					return;
				}
				_carId = value;
				PropertySet(this);
			}
		}

		public gameOnCarHitPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
