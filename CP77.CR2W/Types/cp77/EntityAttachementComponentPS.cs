using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementComponentPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("pendingChildAttachements")] public CArray<EntityAttachementData> PendingChildAttachements { get; set; }

		public EntityAttachementComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
