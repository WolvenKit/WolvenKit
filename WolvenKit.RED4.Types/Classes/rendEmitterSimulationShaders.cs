using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendEmitterSimulationShaders : RedBaseClass
	{
		private CArrayFixedSize<DataBuffer> _simCS;

		[Ordinal(0)] 
		[RED("simCS", 2)] 
		public CArrayFixedSize<DataBuffer> SimCS
		{
			get => GetProperty(ref _simCS);
			set => SetProperty(ref _simCS, value);
		}
	}
}
