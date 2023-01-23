using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldEnvironmentAreaParameters()
		{
			RenderAreaSettings = new() { AreaParameters = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
