using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class LibTreeCTreeResource : CResource
	{
		[Ordinal(1)] 
		[RED("variables")] 
		public LibTreeDefTreeVariablesList Variables
		{
			get => GetPropertyValue<LibTreeDefTreeVariablesList>();
			set => SetPropertyValue<LibTreeDefTreeVariablesList>(value);
		}

		public LibTreeCTreeResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
