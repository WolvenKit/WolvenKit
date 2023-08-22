using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			ActiveGatherAreaRepInfo = new grsGatherAreaReplicatedInfo { EnteredPlayerIDs = new(0) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
