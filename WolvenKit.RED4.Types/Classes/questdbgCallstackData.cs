using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questdbgCallstackData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resourceHash")] 
		public CUInt64 ResourceHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("phases")] 
		public CArray<questdbgCallstackPhase> Phases
		{
			get => GetPropertyValue<CArray<questdbgCallstackPhase>>();
			set => SetPropertyValue<CArray<questdbgCallstackPhase>>(value);
		}

		[Ordinal(2)] 
		[RED("blocks")] 
		public CArray<questdbgCallstackBlock> Blocks
		{
			get => GetPropertyValue<CArray<questdbgCallstackBlock>>();
			set => SetPropertyValue<CArray<questdbgCallstackBlock>>(value);
		}

		[Ordinal(3)] 
		[RED("executed")] 
		public CArray<CUInt64> Executed
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(4)] 
		[RED("failed")] 
		public CArray<CUInt64> Failed
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(5)] 
		[RED("callstackRevision")] 
		public CUInt32 CallstackRevision
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questdbgCallstackData()
		{
			Phases = new();
			Blocks = new();
			Executed = new();
			Failed = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
