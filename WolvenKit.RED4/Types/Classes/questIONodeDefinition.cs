using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class questIONodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("socketName")] 
		public CName SocketName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questIONodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
