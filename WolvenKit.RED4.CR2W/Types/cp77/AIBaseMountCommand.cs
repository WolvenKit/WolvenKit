using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBaseMountCommand : AICommand
	{
		private CHandle<gameMountEventData> _mountData;

		[Ordinal(4)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (CHandle<gameMountEventData>) CR2WTypeManager.Create("handle:gameMountEventData", "mountData", cr2w, this);
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

		public AIBaseMountCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
