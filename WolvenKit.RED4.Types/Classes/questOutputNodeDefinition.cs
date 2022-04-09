using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questOutputNodeDefinition : questIONodeDefinition
	{
		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<questExitType> Type
		{
			get => GetPropertyValue<CEnum<questExitType>>();
			set => SetPropertyValue<CEnum<questExitType>>(value);
		}

		public questOutputNodeDefinition()
		{
			Sockets = new();
			Id = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
