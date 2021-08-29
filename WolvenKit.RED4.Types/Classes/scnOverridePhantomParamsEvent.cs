using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnOverridePhantomParamsEvent : scnSceneEvent
	{
		private scnOverridePhantomParamsEventParams _params;

		[Ordinal(6)] 
		[RED("params")] 
		public scnOverridePhantomParamsEventParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
