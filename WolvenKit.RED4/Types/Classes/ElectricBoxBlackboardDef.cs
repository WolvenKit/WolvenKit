using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElectricBoxBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("isOverriden")] 
		public gamebbScriptID_Bool IsOverriden
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public ElectricBoxBlackboardDef()
		{
			IsOverriden = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
