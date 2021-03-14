using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCInitTask : AIbehaviortaskStackScript
	{
		private CBool _preventSkippingDeathAnimation;

		[Ordinal(0)] 
		[RED("preventSkippingDeathAnimation")] 
		public CBool PreventSkippingDeathAnimation
		{
			get
			{
				if (_preventSkippingDeathAnimation == null)
				{
					_preventSkippingDeathAnimation = (CBool) CR2WTypeManager.Create("Bool", "preventSkippingDeathAnimation", cr2w, this);
				}
				return _preventSkippingDeathAnimation;
			}
			set
			{
				if (_preventSkippingDeathAnimation == value)
				{
					return;
				}
				_preventSkippingDeathAnimation = value;
				PropertySet(this);
			}
		}

		public NPCInitTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
