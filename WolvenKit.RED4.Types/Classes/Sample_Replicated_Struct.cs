using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_Replicated_Struct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("a")] 
		public CBool A
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("b")] 
		public CBool B
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("c")] 
		public CBool C
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("d_not_replicated_still_OK")] 
		public CBool D_not_replicated_still_OK
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Sample_Replicated_Struct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
