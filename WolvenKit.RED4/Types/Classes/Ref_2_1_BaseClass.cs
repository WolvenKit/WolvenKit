using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_2_1_BaseClass : IScriptable
	{
		[Ordinal(0)] 
		[RED("prop1")] 
		public CInt32 Prop1
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("prop2")] 
		public CInt32 Prop2
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("prop3")] 
		public CInt32 Prop3
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Ref_2_1_BaseClass()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
