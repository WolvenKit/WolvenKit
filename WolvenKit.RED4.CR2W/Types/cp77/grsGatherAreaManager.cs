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
			get => GetProperty(ref _activeGatherAreaRepInfo);
			set => SetProperty(ref _activeGatherAreaRepInfo, value);
		}

		public grsGatherAreaManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
