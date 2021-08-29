using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsDespawnEntityEvent : scnSceneEvent
	{
		private scneventsDespawnEntityEventParams _params;

		[Ordinal(6)] 
		[RED("params")] 
		public scneventsDespawnEntityEventParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
