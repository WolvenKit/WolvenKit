using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendEmitterSimulationShaders : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("simCS", 2)] 
		public CArrayFixedSize<DataBuffer> SimCS
		{
			get => GetPropertyValue<CArrayFixedSize<DataBuffer>>();
			set => SetPropertyValue<CArrayFixedSize<DataBuffer>>(value);
		}

		public rendEmitterSimulationShaders()
		{
			SimCS = new(2);
		}
	}
}
