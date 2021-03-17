using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeCTreeReference : ISerializable
	{
		private rRef<LibTreeCTreeResource> _treeDefinition;
		private LibTreeParameterList _parameters;

		[Ordinal(0)] 
		[RED("TreeDefinition")] 
		public rRef<LibTreeCTreeResource> TreeDefinition
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

		public LibTreeCTreeReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
