using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeCTreeReference : ISerializable
	{
		private CResourceReference<LibTreeCTreeResource> _treeDefinition;
		private LibTreeParameterList _parameters;

		[Ordinal(0)] 
		[RED("TreeDefinition")] 
		public CResourceReference<LibTreeCTreeResource> TreeDefinition
		{
			get => GetProperty(ref _treeDefinition);
			set => SetProperty(ref _treeDefinition, value);
		}

		[Ordinal(1)] 
		[RED("parameters")] 
		public LibTreeParameterList Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}
	}
}
