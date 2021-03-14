using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionWsToMs : animAnimNode_QuaternionValue
	{
		private animQuaternionLink _quaternionWs;

		[Ordinal(11)] 
		[RED("quaternionWs")] 
		public animQuaternionLink QuaternionWs
		{
			get
			{
				if (_quaternionWs == null)
				{
					_quaternionWs = (animQuaternionLink) CR2WTypeManager.Create("animQuaternionLink", "quaternionWs", cr2w, this);
				}
				return _quaternionWs;
			}
			set
			{
				if (_quaternionWs == value)
				{
					return;
				}
				_quaternionWs = value;
				PropertySet(this);
			}
		}

		public animAnimNode_QuaternionWsToMs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
