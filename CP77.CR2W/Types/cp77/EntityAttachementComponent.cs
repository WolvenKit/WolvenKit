using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("parentAttachementData")] public EntityAttachementData ParentAttachementData { get; set; }

		public EntityAttachementComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
