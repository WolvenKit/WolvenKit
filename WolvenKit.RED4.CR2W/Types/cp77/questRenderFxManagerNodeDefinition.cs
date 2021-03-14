using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRenderFxManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIRenderFxManagerNodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIRenderFxManagerNodeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questIRenderFxManagerNodeType>) CR2WTypeManager.Create("handle:questIRenderFxManagerNodeType", "type", cr2w, this);
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

		public questRenderFxManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
