using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleGlassTint : ActionBool
	{
		[Ordinal(38)] 
		[RED("TrueRecord")] 
		public CString TrueRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(39)] 
		[RED("FalseRecord")] 
		public CString FalseRecord
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ToggleGlassTint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
