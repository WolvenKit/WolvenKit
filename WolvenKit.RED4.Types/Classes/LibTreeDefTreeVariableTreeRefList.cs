using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefTreeVariableTreeRefList : LibTreeDefTreeVariable
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
		public CArray<CHandle<LibTreeCTreeReference>> DefaultValue
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeCTreeReference>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeCTreeReference>>>(value);
		}

		public LibTreeDefTreeVariableTreeRefList()
		{
			Id = 65535;
			ReadableName = "TreeVar";
			ExportAsProperty = true;
			DefaultValue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
