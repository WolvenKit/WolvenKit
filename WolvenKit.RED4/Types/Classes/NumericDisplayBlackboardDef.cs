using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NumericDisplayBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("CurrentNumber")] 
		public gamebbScriptID_Int32 CurrentNumber
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("Direction")] 
		public gamebbScriptID_Int32 Direction
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		public NumericDisplayBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
