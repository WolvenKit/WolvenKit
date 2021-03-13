using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBlockTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)] [RED("action")] public CEnum<questBlockAction> Action { get; set; }
		[Ordinal(1)] [RED("source")] public CName Source { get; set; }

		public questBlockTokenActivation_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
