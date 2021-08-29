using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class grsGatherAreaManager : RedBaseClass
	{
		private grsGatherAreaReplicatedInfo _activeGatherAreaRepInfo;

		[Ordinal(0)] 
		[RED("activeGatherAreaRepInfo")] 
		public grsGatherAreaReplicatedInfo ActiveGatherAreaRepInfo
		{
			get => GetProperty(ref _activeGatherAreaRepInfo);
			set => SetProperty(ref _activeGatherAreaRepInfo, value);
		}
	}
}
