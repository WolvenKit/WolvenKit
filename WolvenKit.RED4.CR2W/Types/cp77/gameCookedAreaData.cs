using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedAreaData : CVariable
	{
		private entEntityID _entityID;
		private Vector3 _position;
		private CFloat _radius;
		private CHandle<gamemappinsIMappinVolume> _volume;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("volume")] 
		public CHandle<gamemappinsIMappinVolume> Volume
		{
			get
			{
				if (_volume == null)
				{
					_volume = (CHandle<gamemappinsIMappinVolume>) CR2WTypeManager.Create("handle:gamemappinsIMappinVolume", "volume", cr2w, this);
				}
				return _volume;
			}
			set
			{
				if (_volume == value)
				{
					return;
				}
				_volume = value;
				PropertySet(this);
			}
		}

		public gameCookedAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
