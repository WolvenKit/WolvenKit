using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MissingWorkspotComponentFailsafeEvent : redEvent
	{
		private entEntityID _playerEntityID;

		[Ordinal(0)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get
			{
				if (_playerEntityID == null)
				{
					_playerEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "playerEntityID", cr2w, this);
				}
				return _playerEntityID;
			}
			set
			{
				if (_playerEntityID == value)
				{
					return;
				}
				_playerEntityID = value;
				PropertySet(this);
			}
		}

		public MissingWorkspotComponentFailsafeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
