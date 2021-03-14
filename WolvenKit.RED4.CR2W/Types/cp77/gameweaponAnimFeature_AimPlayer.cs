using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_AimPlayer : animAnimFeature_BasicAim
	{
		private CFloat _zoomLevel;
		private CFloat _aimInTime;
		private CFloat _aimOutTime;

		[Ordinal(2)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get
			{
				if (_zoomLevel == null)
				{
					_zoomLevel = (CFloat) CR2WTypeManager.Create("Float", "zoomLevel", cr2w, this);
				}
				return _zoomLevel;
			}
			set
			{
				if (_zoomLevel == value)
				{
					return;
				}
				_zoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("aimInTime")] 
		public CFloat AimInTime
		{
			get
			{
				if (_aimInTime == null)
				{
					_aimInTime = (CFloat) CR2WTypeManager.Create("Float", "aimInTime", cr2w, this);
				}
				return _aimInTime;
			}
			set
			{
				if (_aimInTime == value)
				{
					return;
				}
				_aimInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("aimOutTime")] 
		public CFloat AimOutTime
		{
			get
			{
				if (_aimOutTime == null)
				{
					_aimOutTime = (CFloat) CR2WTypeManager.Create("Float", "aimOutTime", cr2w, this);
				}
				return _aimOutTime;
			}
			set
			{
				if (_aimOutTime == value)
				{
					return;
				}
				_aimOutTime = value;
				PropertySet(this);
			}
		}

		public gameweaponAnimFeature_AimPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
