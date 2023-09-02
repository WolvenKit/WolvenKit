using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSignalId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CUInt16 Value
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public gameSignalId()
		{
			Value = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
