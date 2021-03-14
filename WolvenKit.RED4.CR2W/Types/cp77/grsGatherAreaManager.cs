using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsGatherAreaManager : CVariable
	{
		private grsGatherAreaReplicatedInfo _activeGatherAreaRepInfo;

		[Ordinal(0)] 
		[RED("activeGatherAreaRepInfo")] 
		public grsGatherAreaReplicatedInfo ActiveGatherAreaRepInfo
		{
			get
			{
				if (_activeGatherAreaRepInfo == null)
				{
					_activeGatherAreaRepInfo = (grsGatherAreaReplicatedInfo) CR2WTypeManager.Create("grsGatherAreaReplicatedInfo", "activeGatherAreaRepInfo", cr2w, this);
				}
				return _activeGatherAreaRepInfo;
			}
			set
			{
				if (_activeGatherAreaRepInfo == value)
				{
					return;
				}
				_activeGatherAreaRepInfo = value;
				PropertySet(this);
			}
		}

		public grsGatherAreaManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
