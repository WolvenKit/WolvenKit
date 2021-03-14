using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMasterDeviceComponent : gameComponent
	{
		private CHandle<gamedeviceClearance> _clearance;

		[Ordinal(4)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get
			{
				if (_clearance == null)
				{
					_clearance = (CHandle<gamedeviceClearance>) CR2WTypeManager.Create("handle:gamedeviceClearance", "clearance", cr2w, this);
				}
				return _clearance;
			}
			set
			{
				if (_clearance == value)
				{
					return;
				}
				_clearance = value;
				PropertySet(this);
			}
		}

		public gameMasterDeviceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
