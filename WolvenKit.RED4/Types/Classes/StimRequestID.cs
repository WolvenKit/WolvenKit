using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimRequestID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public CUInt32 ID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StimRequestID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
