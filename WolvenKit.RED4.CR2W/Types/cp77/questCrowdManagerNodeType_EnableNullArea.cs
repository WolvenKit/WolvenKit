using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCrowdManagerNodeType_EnableNullArea : questICrowdManager_NodeType
	{
		private NodeRef _areaReference;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("areaReference")] 
		public NodeRef AreaReference
		{
			get => GetProperty(ref _areaReference);
			set => SetProperty(ref _areaReference, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public questCrowdManagerNodeType_EnableNullArea(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
