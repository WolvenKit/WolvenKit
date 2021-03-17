using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questElevator_ManageNPCAttachment_NodeType : questIInteractiveObjectManagerNodeType
	{
		private CArray<questElevator_ManageNPCAttachment_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questElevator_ManageNPCAttachment_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questElevator_ManageNPCAttachment_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
