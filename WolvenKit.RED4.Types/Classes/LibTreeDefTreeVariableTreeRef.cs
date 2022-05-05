using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefTreeVariableTreeRef : LibTreeDefTreeVariable
	{
		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("defaultValue")] 
		public CHandle<LibTreeCTreeReference> DefaultValue
		{
			get => GetPropertyValue<CHandle<LibTreeCTreeReference>>();
			set => SetPropertyValue<CHandle<LibTreeCTreeReference>>(value);
		}

		public LibTreeDefTreeVariableTreeRef()
		{
			Id = 65535;
			ReadableName = "TreeVar";
			ExportAsProperty = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
