using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_4_2_2_ConstantHandles : IScriptable
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
		[RED("s")] 
		public CHandle<IScriptable> S
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public Ref_4_2_2_ConstantHandles()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
