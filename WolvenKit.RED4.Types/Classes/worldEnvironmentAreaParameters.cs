using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEnvironmentAreaParameters : CResource
	{
		private WorldRenderAreaSettings _renderAreaSettings;
		private CBool _resaved;

		[Ordinal(1)] 
		[RED("renderAreaSettings")] 
		public WorldRenderAreaSettings RenderAreaSettings
		{
			get => GetProperty(ref _renderAreaSettings);
			set => SetProperty(ref _renderAreaSettings, value);
		}

		[Ordinal(2)] 
		[RED("resaved")] 
		public CBool Resaved
		{
			get => GetProperty(ref _resaved);
			set => SetProperty(ref _resaved, value);
		}
	}
}
