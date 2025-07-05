using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemInputTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("cachedEvt")] 
		public CHandle<SecuritySystemInput> CachedEvt
		{
			get => GetPropertyValue<CHandle<SecuritySystemInput>>();
			set => SetPropertyValue<CHandle<SecuritySystemInput>>(value);
		}

		public SecuritySystemInputTaskData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
