using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDebugLogScope : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public AIDebugLogScope()
		{
			Index = 4294967295;
			Id = 4294967295;
		}
	}
}
