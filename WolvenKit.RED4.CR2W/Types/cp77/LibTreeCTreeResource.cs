using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeCTreeResource : CResource
	{
		private LibTreeDefTreeVariablesList _variables;

		[Ordinal(1)] 
		[RED("variables")] 
		public LibTreeDefTreeVariablesList Variables
		{
			get => GetProperty(ref _variables);
			set => SetProperty(ref _variables, value);
		}

		public LibTreeCTreeResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
