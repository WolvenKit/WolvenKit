using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetMeshAppearance_NodeType : questIEntityManager_NodeType
	{
		private CArray<questEntityManagerSetMeshAppearance_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questEntityManagerSetMeshAppearance_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questEntityManagerSetMeshAppearance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
