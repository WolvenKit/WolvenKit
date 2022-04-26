using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FollowNPCDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("Position")] 
		public gamebbScriptID_Vector4 Position
		{
			get => GetPropertyValue<gamebbScriptID_Vector4>();
			set => SetPropertyValue<gamebbScriptID_Vector4>(value);
		}

		public FollowNPCDef()
		{
			Position = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
