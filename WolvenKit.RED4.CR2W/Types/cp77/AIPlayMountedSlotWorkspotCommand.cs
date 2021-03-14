using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPlayMountedSlotWorkspotCommand : AICommand
	{
		private gameMountDescriptor _mountData;

		[Ordinal(4)] 
		[RED("mountData")] 
		public gameMountDescriptor MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (gameMountDescriptor) CR2WTypeManager.Create("gameMountDescriptor", "mountData", cr2w, this);
				}
				return _mountData;
			}
			set
			{
				if (_mountData == value)
				{
					return;
				}
				_mountData = value;
				PropertySet(this);
			}
		}

		public AIPlayMountedSlotWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
