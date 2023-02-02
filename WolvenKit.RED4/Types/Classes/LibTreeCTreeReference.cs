using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeCTreeReference : ISerializable
	{
		[Ordinal(0)] 
		[RED("TreeDefinition")] 
		public CResourceReference<LibTreeCTreeResource> TreeDefinition
		{
			get => GetPropertyValue<CResourceReference<LibTreeCTreeResource>>();
			set => SetPropertyValue<CResourceReference<LibTreeCTreeResource>>(value);
		}

		[Ordinal(1)] 
		[RED("parameters")] 
		public LibTreeParameterList Parameters
		{
			get => GetPropertyValue<LibTreeParameterList>();
			set => SetPropertyValue<LibTreeParameterList>(value);
		}

		public LibTreeCTreeReference()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
