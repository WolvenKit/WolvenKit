using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsSpawnEntityEvent : scnSceneEvent
	{
		private scneventsSpawnEntityEventParams _params;

		[Ordinal(6)] 
		[RED("params")] 
		public scneventsSpawnEntityEventParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
