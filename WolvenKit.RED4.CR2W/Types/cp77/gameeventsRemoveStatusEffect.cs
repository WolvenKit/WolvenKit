using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsRemoveStatusEffect : gameeventsStatusEffectEvent
	{
		private CBool _isFinalRemoval;

		[Ordinal(2)] 
		[RED("isFinalRemoval")] 
		public CBool IsFinalRemoval
		{
			get
			{
				if (_isFinalRemoval == null)
				{
					_isFinalRemoval = (CBool) CR2WTypeManager.Create("Bool", "isFinalRemoval", cr2w, this);
				}
				return _isFinalRemoval;
			}
			set
			{
				if (_isFinalRemoval == value)
				{
					return;
				}
				_isFinalRemoval = value;
				PropertySet(this);
			}
		}

		public gameeventsRemoveStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
