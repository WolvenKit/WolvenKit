using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatToIntConverter : animAnimNode_IntValue
	{
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "inputNode", cr2w, this);
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

		public animAnimNode_FloatToIntConverter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
