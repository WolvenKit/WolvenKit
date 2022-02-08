using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEnvironmentAreaParameters : CResource
	{
		[Ordinal(1)] 
		[RED("renderAreaSettings")] 
		public WorldRenderAreaSettings RenderAreaSettings
		{
			get => GetPropertyValue<WorldRenderAreaSettings>();
			set => SetPropertyValue<WorldRenderAreaSettings>(value);
		}

		[Ordinal(2)] 
		[RED("resaved")] 
		public CBool Resaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldEnvironmentAreaParameters()
		{
			RenderAreaSettings = new() { AreaParameters = new() };
		}
	}
}
