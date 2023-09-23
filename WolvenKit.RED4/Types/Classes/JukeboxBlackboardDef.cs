using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JukeboxBlackboardDef : DeviceBaseBlackboardDef
	{
		[Ordinal(7)] 
		[RED("IsPlaying")] 
		public gamebbScriptID_Bool IsPlaying
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public JukeboxBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
