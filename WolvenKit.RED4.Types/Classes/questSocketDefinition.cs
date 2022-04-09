using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSocketDefinition : graphGraphSocketDefinition
	{
		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<questSocketType> Type
		{
			get => GetPropertyValue<CEnum<questSocketType>>();
			set => SetPropertyValue<CEnum<questSocketType>>(value);
		}

		public questSocketDefinition()
		{
			Connections = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
