using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WoundedInstigated : redEvent
	{
		private CEnum<EHitReactionZone> _bodyPart;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<EHitReactionZone> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<EHitReactionZone>) CR2WTypeManager.Create("EHitReactionZone", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		public WoundedInstigated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
