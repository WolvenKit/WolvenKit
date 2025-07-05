using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedebugFailureId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("threadId")] 
		public CUInt32 ThreadId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("unsignedId")] 
		public CUInt32 UnsignedId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gamedebugFailureId()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
