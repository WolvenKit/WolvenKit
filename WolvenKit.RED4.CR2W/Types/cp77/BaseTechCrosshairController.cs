using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseTechCrosshairController : gameuiCrosshairBaseGameController
	{
		private wCHandle<gameObject> _player;
		private CHandle<gameStatsSystem> _statsSystem;
		private CBool _fullChargeAvailable;
		private CBool _overChargeAvailable;
		private CHandle<CrosshairWeaponStatsListener> _fullChargeListener;
		private CHandle<CrosshairWeaponStatsListener> _overChargeListener;

		[Ordinal(18)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("fullChargeAvailable")] 
		public CBool FullChargeAvailable
		{
			get
			{
				if (_fullChargeAvailable == null)
				{
					_fullChargeAvailable = (CBool) CR2WTypeManager.Create("Bool", "fullChargeAvailable", cr2w, this);
				}
				return _fullChargeAvailable;
			}
			set
			{
				if (_fullChargeAvailable == value)
				{
					return;
				}
				_fullChargeAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("overChargeAvailable")] 
		public CBool OverChargeAvailable
		{
			get
			{
				if (_overChargeAvailable == null)
				{
					_overChargeAvailable = (CBool) CR2WTypeManager.Create("Bool", "overChargeAvailable", cr2w, this);
				}
				return _overChargeAvailable;
			}
			set
			{
				if (_overChargeAvailable == value)
				{
					return;
				}
				_overChargeAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("fullChargeListener")] 
		public CHandle<CrosshairWeaponStatsListener> FullChargeListener
		{
			get
			{
				if (_fullChargeListener == null)
				{
					_fullChargeListener = (CHandle<CrosshairWeaponStatsListener>) CR2WTypeManager.Create("handle:CrosshairWeaponStatsListener", "fullChargeListener", cr2w, this);
				}
				return _fullChargeListener;
			}
			set
			{
				if (_fullChargeListener == value)
				{
					return;
				}
				_fullChargeListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("overChargeListener")] 
		public CHandle<CrosshairWeaponStatsListener> OverChargeListener
		{
			get
			{
				if (_overChargeListener == null)
				{
					_overChargeListener = (CHandle<CrosshairWeaponStatsListener>) CR2WTypeManager.Create("handle:CrosshairWeaponStatsListener", "overChargeListener", cr2w, this);
				}
				return _overChargeListener;
			}
			set
			{
				if (_overChargeListener == value)
				{
					return;
				}
				_overChargeListener = value;
				PropertySet(this);
			}
		}

		public BaseTechCrosshairController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
