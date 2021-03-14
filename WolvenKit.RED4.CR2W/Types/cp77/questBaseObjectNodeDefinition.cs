using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBaseObjectNodeDefinition : questDisableableNodeDefinition
	{
		private NodeRef _reference;

		[Ordinal(2)] 
		[RED("reference")] 
		public NodeRef Reference
		{
			get
			{
				if (_reference == null)
				{
					_reference = (NodeRef) CR2WTypeManager.Create("NodeRef", "reference", cr2w, this);
				}
				return _reference;
			}
			set
			{
				if (_reference == value)
				{
					return;
				}
				_reference = value;
				PropertySet(this);
			}
		}

		public questBaseObjectNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
