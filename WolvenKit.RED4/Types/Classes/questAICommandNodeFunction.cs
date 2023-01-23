using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAICommandNodeFunction : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("order")] 
		public CUInt32 Order
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("nodeType")] 
		public CName NodeType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("commandCategory")] 
		public CName CommandCategory
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("friendlyName")] 
		public CString FriendlyName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("paramsType")] 
		public CName ParamsType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("nodeColor")] 
		public CColor NodeColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public questAICommandNodeFunction()
		{
			NodeColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
