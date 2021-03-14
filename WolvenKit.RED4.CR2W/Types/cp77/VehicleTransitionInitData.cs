using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleTransitionInitData : IScriptable
	{
		private CBool _instant;
		private entEntityID _entityID;
		private CBool _alive;
		private CBool _occupiedByNeutral;

		[Ordinal(0)] 
		[RED("instant")] 
		public CBool Instant
		{
			get
			{
				if (_instant == null)
				{
					_instant = (CBool) CR2WTypeManager.Create("Bool", "instant", cr2w, this);
				}
				return _instant;
			}
			set
			{
				if (_instant == value)
				{
					return;
				}
				_instant = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("alive")] 
		public CBool Alive
		{
			get
			{
				if (_alive == null)
				{
					_alive = (CBool) CR2WTypeManager.Create("Bool", "alive", cr2w, this);
				}
				return _alive;
			}
			set
			{
				if (_alive == value)
				{
					return;
				}
				_alive = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("occupiedByNeutral")] 
		public CBool OccupiedByNeutral
		{
			get
			{
				if (_occupiedByNeutral == null)
				{
					_occupiedByNeutral = (CBool) CR2WTypeManager.Create("Bool", "occupiedByNeutral", cr2w, this);
				}
				return _occupiedByNeutral;
			}
			set
			{
				if (_occupiedByNeutral == value)
				{
					return;
				}
				_occupiedByNeutral = value;
				PropertySet(this);
			}
		}

		public VehicleTransitionInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
