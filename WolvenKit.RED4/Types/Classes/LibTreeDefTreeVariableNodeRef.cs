using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefTreeVariableNodeRef : LibTreeDefTreeVariable
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
		public NodeRef DefaultValue
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public LibTreeDefTreeVariableNodeRef()
		{
			Id = ushort.MaxValue;
			ReadableName = "TreeVar";
			ExportAsProperty = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
