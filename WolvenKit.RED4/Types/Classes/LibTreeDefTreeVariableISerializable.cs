using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefTreeVariableISerializable : LibTreeDefTreeVariable
	{
		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LibTreeDefTreeVariableISerializable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
