using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedAnimWrapperVars : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("serverReplicatedTime")] 
		public netTime ServerReplicatedTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CArray<entReplicatedVariableValue> Data
		{
			get => GetPropertyValue<CArray<entReplicatedVariableValue>>();
			set => SetPropertyValue<CArray<entReplicatedVariableValue>>(value);
		}

		public entReplicatedAnimWrapperVars()
		{
			ServerReplicatedTime = new netTime();
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
