using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionLatch : animAnimNode_QuaternionValue
	{
		private animQuaternionLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animQuaternionLink Input
		{
			get
			{
				if (_input == null)
				{
					_input = (animQuaternionLink) CR2WTypeManager.Create("animQuaternionLink", "input", cr2w, this);
				}
				return _input;
			}
			set
			{
				if (_input == value)
				{
					return;
				}
				_input = value;
				PropertySet(this);
			}
		}

		public animAnimNode_QuaternionLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
