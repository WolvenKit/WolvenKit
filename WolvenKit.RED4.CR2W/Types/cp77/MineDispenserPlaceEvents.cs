using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MineDispenserPlaceEvents : MineDispenserEventsTransition
	{
		private Vector4 _spawnPosition;
		private Vector4 _spawnNormal;

		[Ordinal(0)] 
		[RED("spawnPosition")] 
		public Vector4 SpawnPosition
		{
			get
			{
				if (_spawnPosition == null)
				{
					_spawnPosition = (Vector4) CR2WTypeManager.Create("Vector4", "spawnPosition", cr2w, this);
				}
				return _spawnPosition;
			}
			set
			{
				if (_spawnPosition == value)
				{
					return;
				}
				_spawnPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spawnNormal")] 
		public Vector4 SpawnNormal
		{
			get
			{
				if (_spawnNormal == null)
				{
					_spawnNormal = (Vector4) CR2WTypeManager.Create("Vector4", "spawnNormal", cr2w, this);
				}
				return _spawnNormal;
			}
			set
			{
				if (_spawnNormal == value)
				{
					return;
				}
				_spawnNormal = value;
				PropertySet(this);
			}
		}

		public MineDispenserPlaceEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
