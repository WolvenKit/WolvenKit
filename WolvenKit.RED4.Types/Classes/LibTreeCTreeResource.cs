using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeCTreeResource : CResource
	{
		[Ordinal(1)] 
		[RED("variables")] 
		public LibTreeDefTreeVariablesList Variables
		{
			get => GetPropertyValue<LibTreeDefTreeVariablesList>();
			set => SetPropertyValue<LibTreeDefTreeVariablesList>(value);
		}
	}
}
