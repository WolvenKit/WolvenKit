using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDumpBodyDelayEvent : redEvent
	{
		private wCHandle<gameObject> _bodyToDump;
		private CHandle<gameIBlackboard> _psm;

		[Ordinal(0)] 
		[RED("bodyToDump")] 
		public wCHandle<gameObject> BodyToDump
		{
			get
			{
				if (_bodyToDump == null)
				{
					_bodyToDump = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "bodyToDump", cr2w, this);
				}
				return _bodyToDump;
			}
			set
			{
				if (_bodyToDump == value)
				{
					return;
				}
				_bodyToDump = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("psm")] 
		public CHandle<gameIBlackboard> Psm
		{
			get
			{
				if (_psm == null)
				{
					_psm = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "psm", cr2w, this);
				}
				return _psm;
			}
			set
			{
				if (_psm == value)
				{
					return;
				}
				_psm = value;
				PropertySet(this);
			}
		}

		public VehicleDumpBodyDelayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
