using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalItemTooltipDataStatRequirement : IScriptable
	{
		[Ordinal(0)] 
		[RED("statName")] 
		public CString StatName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("statColor")] 
		public CString StatColor
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("statLocKey")] 
		public CString StatLocKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("statValue")] 
		public CInt32 StatValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public MinimalItemTooltipDataStatRequirement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
