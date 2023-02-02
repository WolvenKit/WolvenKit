using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldRenderAreaSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaParameters")] 
		public CArray<CHandle<IAreaSettings>> AreaParameters
		{
			get => GetPropertyValue<CArray<CHandle<IAreaSettings>>>();
			set => SetPropertyValue<CArray<CHandle<IAreaSettings>>>(value);
		}

		public WorldRenderAreaSettings()
		{
			AreaParameters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
