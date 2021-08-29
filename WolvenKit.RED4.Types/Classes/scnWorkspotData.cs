using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnWorkspotData : ISerializable
	{
		private scnSceneWorkspotDataId _dataId;

		[Ordinal(0)] 
		[RED("dataId")] 
		public scnSceneWorkspotDataId DataId
		{
			get => GetProperty(ref _dataId);
			set => SetProperty(ref _dataId, value);
		}
	}
}
