using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefTreeVariableFloat : LibTreeDefTreeVariable
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
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public LibTreeDefTreeVariableFloat()
		{
			Id = 65535;
			ReadableName = "TreeVar";
			ExportAsProperty = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
