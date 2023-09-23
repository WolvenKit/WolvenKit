using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinesDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("CurrentNormal")] 
		public gamebbScriptID_Vector4 CurrentNormal
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		public MinesDataDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
