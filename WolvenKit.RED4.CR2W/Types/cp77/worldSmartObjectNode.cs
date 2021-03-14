using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSmartObjectNode : worldNode
	{
		private CHandle<gameSmartObjectDefinition> _object;

		[Ordinal(4)] 
		[RED("object")] 
		public CHandle<gameSmartObjectDefinition> Object
		{
			get
			{
				if (_object == null)
				{
					_object = (CHandle<gameSmartObjectDefinition>) CR2WTypeManager.Create("handle:gameSmartObjectDefinition", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
				PropertySet(this);
			}
		}

		public worldSmartObjectNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
