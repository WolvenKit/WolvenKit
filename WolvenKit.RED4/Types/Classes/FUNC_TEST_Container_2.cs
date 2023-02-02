using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FUNC_TEST_Container_2 : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("FloatBox")] 
		public CFloat FloatBox
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("IntBox")] 
		public CInt32 IntBox
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("BoolBox")] 
		public CBool BoolBox
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("NameBox")] 
		public CName NameBox
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("StringBox")] 
		public CString StringBox
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("CNameBox")] 
		public CName CNameBox
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("TweakBox")] 
		public TweakDBID TweakBox
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public FUNC_TEST_Container_2()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
