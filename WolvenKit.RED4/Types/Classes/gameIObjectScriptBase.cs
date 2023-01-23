using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameIObjectScriptBase : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameObject")] 
		public CHandle<gameObject> GameObject
		{
			get => GetPropertyValue<CHandle<gameObject>>();
			set => SetPropertyValue<CHandle<gameObject>>(value);
		}

		public gameIObjectScriptBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
