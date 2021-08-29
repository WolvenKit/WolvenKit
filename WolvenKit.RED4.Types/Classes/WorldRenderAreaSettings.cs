using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldRenderAreaSettings : RedBaseClass
	{
		private CArray<CHandle<IAreaSettings>> _areaParameters;

		[Ordinal(0)] 
		[RED("areaParameters")] 
		public CArray<CHandle<IAreaSettings>> AreaParameters
		{
			get => GetProperty(ref _areaParameters);
			set => SetProperty(ref _areaParameters, value);
		}
	}
}
