using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FullSystemRestart : ActionBool
	{
		[Ordinal(38)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public FullSystemRestart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
