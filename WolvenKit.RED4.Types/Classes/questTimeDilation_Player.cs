using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeDilation_Player : questTimeDilation_NodeTypeParam
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

		public questTimeDilation_Player()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
