using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerWokrspotDeviceOperation : DeviceOperationBase
	{
		private SWorkspotData _playerWorkspot;

		[Ordinal(5)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get
			{
				if (_playerWorkspot == null)
				{
					_playerWorkspot = (SWorkspotData) CR2WTypeManager.Create("SWorkspotData", "playerWorkspot", cr2w, this);
				}
				return _playerWorkspot;
			}
			set
			{
				if (_playerWorkspot == value)
				{
					return;
				}
				_playerWorkspot = value;
				PropertySet(this);
			}
		}

		public PlayerWokrspotDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
