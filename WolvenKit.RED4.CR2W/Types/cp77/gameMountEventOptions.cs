using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMountEventOptions : IScriptable
	{
		private CBool _silentUnmount;
		private entEntityID _entityID;
		private CBool _alive;
		private CBool _occupiedByNeutral;

		[Ordinal(0)] 
		[RED("silentUnmount")] 
		public CBool SilentUnmount
		{
			get
			{
				if (_silentUnmount == null)
				{
					_silentUnmount = (CBool) CR2WTypeManager.Create("Bool", "silentUnmount", cr2w, this);
				}
				return _silentUnmount;
			}
			set
			{
				if (_silentUnmount == value)
				{
					return;
				}
				_silentUnmount = value;
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

		public gameMountEventOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
