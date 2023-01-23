using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionScript : gameIObjectScriptBase
	{
		[Ordinal(1)] 
		[RED("actionFlags")] 
		public CUInt32 ActionFlags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameActionScript()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
