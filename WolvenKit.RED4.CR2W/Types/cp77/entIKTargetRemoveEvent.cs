using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIKTargetRemoveEvent : redEvent
	{
		private animIKTargetRef _ikTargetRef;

		[Ordinal(0)] 
		[RED("ikTargetRef")] 
		public animIKTargetRef IkTargetRef
		{
			get
			{
				if (_ikTargetRef == null)
				{
					_ikTargetRef = (animIKTargetRef) CR2WTypeManager.Create("animIKTargetRef", "ikTargetRef", cr2w, this);
				}
				return _ikTargetRef;
			}
			set
			{
				if (_ikTargetRef == value)
				{
					return;
				}
				_ikTargetRef = value;
				PropertySet(this);
			}
		}

		public entIKTargetRemoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
