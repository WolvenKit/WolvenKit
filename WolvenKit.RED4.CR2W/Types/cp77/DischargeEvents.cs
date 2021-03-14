using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DischargeEvents : WeaponEventsTransition
	{
		private CUInt32 _layerId;
		private CHandle<gameStatPoolsSystem> _statPoolsSystem;
		private CHandle<gameStatsSystem> _statsSystem;
		private entEntityID _weaponID;

		[Ordinal(0)] 
		[RED("layerId")] 
		public CUInt32 LayerId
		{
			get
			{
				if (_layerId == null)
				{
					_layerId = (CUInt32) CR2WTypeManager.Create("Uint32", "layerId", cr2w, this);
				}
				return _layerId;
			}
			set
			{
				if (_layerId == value)
				{
					return;
				}
				_layerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("statPoolsSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolsSystem
		{
			get
			{
				if (_statPoolsSystem == null)
				{
					_statPoolsSystem = (CHandle<gameStatPoolsSystem>) CR2WTypeManager.Create("handle:gameStatPoolsSystem", "statPoolsSystem", cr2w, this);
				}
				return _statPoolsSystem;
			}
			set
			{
				if (_statPoolsSystem == value)
				{
					return;
				}
				_statPoolsSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get
			{
				if (_statsSystem == null)
				{
					_statsSystem = (CHandle<gameStatsSystem>) CR2WTypeManager.Create("handle:gameStatsSystem", "statsSystem", cr2w, this);
				}
				return _statsSystem;
			}
			set
			{
				if (_statsSystem == value)
				{
					return;
				}
				_statsSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (entEntityID) CR2WTypeManager.Create("entEntityID", "weaponID", cr2w, this);
				}
				return _weaponID;
			}
			set
			{
				if (_weaponID == value)
				{
					return;
				}
				_weaponID = value;
				PropertySet(this);
			}
		}

		public DischargeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
