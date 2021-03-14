using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_IntToFloatConverter : animAnimNode_FloatValue
	{
		private animIntLink _inputNode;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animIntLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animIntLink) CR2WTypeManager.Create("animIntLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_IntToFloatConverter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
