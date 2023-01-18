using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSyncNodeSignal : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public CUInt32 NodeId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CUInt16 Name
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("ordinal")] 
		public CUInt16 Ordinal
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("numRuns")] 
		public CUInt16 NumRuns
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public scnSyncNodeSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
