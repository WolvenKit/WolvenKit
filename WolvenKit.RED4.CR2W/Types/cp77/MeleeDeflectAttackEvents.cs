using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeDeflectAttackEvents : MeleeAttackGenericEvents
	{
		private CBool _slowMoSet;

		[Ordinal(8)] 
		[RED("slowMoSet")] 
		public CBool SlowMoSet
		{
			get
			{
				if (_slowMoSet == null)
				{
					_slowMoSet = (CBool) CR2WTypeManager.Create("Bool", "slowMoSet", cr2w, this);
				}
				return _slowMoSet;
			}
			set
			{
				if (_slowMoSet == value)
				{
					return;
				}
				_slowMoSet = value;
				PropertySet(this);
			}
		}

		public MeleeDeflectAttackEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
