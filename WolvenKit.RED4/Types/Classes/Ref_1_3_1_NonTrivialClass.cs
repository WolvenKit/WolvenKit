using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_1_3_1_NonTrivialClass : IScriptable
	{
		[Ordinal(0)] 
		[RED("prop1")] 
		public CFloat Prop1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("prop2")] 
		public CHandle<Ref_1_3_1_TrivialClass> Prop2
		{
			get => GetPropertyValue<CHandle<Ref_1_3_1_TrivialClass>>();
			set => SetPropertyValue<CHandle<Ref_1_3_1_TrivialClass>>(value);
		}

		public Ref_1_3_1_NonTrivialClass()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
