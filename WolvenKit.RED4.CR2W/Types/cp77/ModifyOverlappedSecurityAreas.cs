using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyOverlappedSecurityAreas : redEvent
	{
		private CBool _isEntering;
		private gamePersistentID _zoneID;

		[Ordinal(0)] 
		[RED("isEntering")] 
		public CBool IsEntering
		{
			get
			{
				if (_isEntering == null)
				{
					_isEntering = (CBool) CR2WTypeManager.Create("Bool", "isEntering", cr2w, this);
				}
				return _isEntering;
			}
			set
			{
				if (_isEntering == value)
				{
					return;
				}
				_isEntering = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("zoneID")] 
		public gamePersistentID ZoneID
		{
			get
			{
				if (_zoneID == null)
				{
					_zoneID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "zoneID", cr2w, this);
				}
				return _zoneID;
			}
			set
			{
				if (_zoneID == value)
				{
					return;
				}
				_zoneID = value;
				PropertySet(this);
			}
		}

		public ModifyOverlappedSecurityAreas(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
