using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TooltipSpawnedCallbackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("tooltipStyle")] 
		public CEnum<ETooltipsStyle> TooltipStyle
		{
			get => GetPropertyValue<CEnum<ETooltipsStyle>>();
			set => SetPropertyValue<CEnum<ETooltipsStyle>>(value);
		}

		[Ordinal(3)] 
		[RED("styleResRef")] 
		public redResourceReferenceScriptToken StyleResRef
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public TooltipSpawnedCallbackData()
		{
			Index = -1;
			StyleResRef = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
