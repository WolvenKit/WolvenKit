using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhoneManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("type")] public CHandle<questIPhoneManagerNodeType> Type { get; set; }

		public questPhoneManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
