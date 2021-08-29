using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeCTreeResource : CResource
	{
		private LibTreeDefTreeVariablesList _variables;

		[Ordinal(1)] 
		[RED("variables")] 
		public LibTreeDefTreeVariablesList Variables
		{
			get => GetProperty(ref _variables);
			set => SetProperty(ref _variables, value);
		}
	}
}
