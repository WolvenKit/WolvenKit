using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_4_4_Hints : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("f")] 
		public CFloat F
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("b")] 
		public CBool B
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("s")] 
		public CString S
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public Ref_4_4_Hints()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
