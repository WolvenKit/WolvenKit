using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class grsGatherAreaManager : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("activeGatherAreaRepInfo")] 
		public grsGatherAreaReplicatedInfo ActiveGatherAreaRepInfo
		{
			get => GetPropertyValue<grsGatherAreaReplicatedInfo>();
			set => SetPropertyValue<grsGatherAreaReplicatedInfo>(value);
		}

		public grsGatherAreaManager()
		{
			ActiveGatherAreaRepInfo = new() { EnteredPlayerIDs = new(0) };
		}
	}
}
