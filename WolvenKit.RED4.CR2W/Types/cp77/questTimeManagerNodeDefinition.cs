using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questITimeManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questITimeManagerNodeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questITimeManagerNodeType>) CR2WTypeManager.Create("handle:questITimeManagerNodeType", "type", cr2w, this);
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

		public questTimeManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
