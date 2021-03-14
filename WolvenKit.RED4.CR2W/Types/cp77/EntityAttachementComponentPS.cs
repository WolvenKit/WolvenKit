using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementComponentPS : gameComponentPS
	{
		private CArray<EntityAttachementData> _pendingChildAttachements;

		[Ordinal(0)] 
		[RED("pendingChildAttachements")] 
		public CArray<EntityAttachementData> PendingChildAttachements
		{
			get
			{
				if (_pendingChildAttachements == null)
				{
					_pendingChildAttachements = (CArray<EntityAttachementData>) CR2WTypeManager.Create("array:EntityAttachementData", "pendingChildAttachements", cr2w, this);
				}
				return _pendingChildAttachements;
			}
			set
			{
				if (_pendingChildAttachements == value)
				{
					return;
				}
				_pendingChildAttachements = value;
				PropertySet(this);
			}
		}

		public EntityAttachementComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
