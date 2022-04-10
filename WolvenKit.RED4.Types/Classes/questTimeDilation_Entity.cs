using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimeDilation_Entity : questTimeDilation_NodeTypeParam
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
		[RED("parentTimeDilationOverride")] 
		public CEnum<questETimeDilationOverride> ParentTimeDilationOverride
		{
			get => GetPropertyValue<CEnum<questETimeDilationOverride>>();
			set => SetPropertyValue<CEnum<questETimeDilationOverride>>(value);
		}

		[Ordinal(3)] 
		[RED("entities")] 
		public CArray<NodeRef> Entities
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		public questTimeDilation_Entity()
		{
			Entities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
