using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("parentAttachementData")] public EntityAttachementData ParentAttachementData { get; set; }

		public EntityAttachementComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
