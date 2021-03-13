using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementComponentPS : gameComponentPS
	{
		[Ordinal(0)] [RED("pendingChildAttachements")] public CArray<EntityAttachementData> PendingChildAttachements { get; set; }

		public EntityAttachementComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
