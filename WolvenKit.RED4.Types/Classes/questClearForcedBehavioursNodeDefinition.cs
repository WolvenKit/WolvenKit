using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questClearForcedBehavioursNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questClearForcedBehavioursNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Puppet = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
