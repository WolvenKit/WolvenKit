using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questChangeVoicesetState_NodeType : questIVoicesetManager_NodeType
	{
		[Ordinal(0)] [RED("params")] public CArray<questChangeVoicesetState_NodeTypeParams> Params { get; set; }

		public questChangeVoicesetState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
