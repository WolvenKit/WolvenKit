using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnWorkspotData : ISerializable
	{
		[Ordinal(0)] 
		[RED("dataId")] 
		public scnSceneWorkspotDataId DataId
		{
			get => GetPropertyValue<scnSceneWorkspotDataId>();
			set => SetPropertyValue<scnSceneWorkspotDataId>(value);
		}

		public scnWorkspotData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
