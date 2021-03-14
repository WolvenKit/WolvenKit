using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementComponent : gameScriptableComponent
	{
		private EntityAttachementData _parentAttachementData;

		[Ordinal(5)] 
		[RED("parentAttachementData")] 
		public EntityAttachementData ParentAttachementData
		{
			get
			{
				if (_parentAttachementData == null)
				{
					_parentAttachementData = (EntityAttachementData) CR2WTypeManager.Create("EntityAttachementData", "parentAttachementData", cr2w, this);
				}
				return _parentAttachementData;
			}
			set
			{
				if (_parentAttachementData == value)
				{
					return;
				}
				_parentAttachementData = value;
				PropertySet(this);
			}
		}

		public EntityAttachementComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
