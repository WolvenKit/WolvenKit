using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeDilation_Puppet : questTimeDilation_NodeTypeParam
	{
		[Ordinal(0)] 
		[RED("operation")] 
		public CHandle<questTimeDilation_Operation> Operation
		{
			get => GetPropertyValue<CHandle<questTimeDilation_Operation>>();
			set => SetPropertyValue<CHandle<questTimeDilation_Operation>>(value);
		}

		[Ordinal(1)] 
		[RED("globalTimeDilationOverride")] 
		public CEnum<questETimeDilationOverride> GlobalTimeDilationOverride
		{
			get => GetPropertyValue<CEnum<questETimeDilationOverride>>();
			set => SetPropertyValue<CEnum<questETimeDilationOverride>>(value);
		}

		[Ordinal(2)] 
		[RED("puppets")] 
		public gameEntityReference Puppets
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questTimeDilation_Puppet()
		{
			Puppets = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
