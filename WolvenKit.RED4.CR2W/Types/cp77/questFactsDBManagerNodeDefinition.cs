using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFactsDBManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIFactsDBManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIFactsDBManagerNodeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questIFactsDBManagerNodeType>) CR2WTypeManager.Create("handle:questIFactsDBManagerNodeType", "type", cr2w, this);
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

		public questFactsDBManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
