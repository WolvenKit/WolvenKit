using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopRTTIClassDumpEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("b")] 
		public CInt32 B
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("r")] 
		public CInt32 R
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("a")] 
		public CInt32 A
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public interopRTTIClassDumpEntry()
		{
			I = -1;
			B = -1;
			R = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
