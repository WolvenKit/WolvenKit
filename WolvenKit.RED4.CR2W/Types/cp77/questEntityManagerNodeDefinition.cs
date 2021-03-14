using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIEntityManager_NodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIEntityManager_NodeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questIEntityManager_NodeType>) CR2WTypeManager.Create("handle:questIEntityManager_NodeType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public questEntityManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
