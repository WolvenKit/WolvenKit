using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBinkVideoRecord : ISerializable
	{
		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt64 ResourceHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("binkDuration")] 
		public CFloat BinkDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameBinkVideoRecord()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
