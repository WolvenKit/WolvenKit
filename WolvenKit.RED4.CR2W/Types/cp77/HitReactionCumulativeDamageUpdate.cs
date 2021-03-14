using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitReactionCumulativeDamageUpdate : redEvent
	{
		private CFloat _prevUpdateTime;

		[Ordinal(0)] 
		[RED("prevUpdateTime")] 
		public CFloat PrevUpdateTime
		{
			get
			{
				if (_prevUpdateTime == null)
				{
					_prevUpdateTime = (CFloat) CR2WTypeManager.Create("Float", "prevUpdateTime", cr2w, this);
				}
				return _prevUpdateTime;
			}
			set
			{
				if (_prevUpdateTime == value)
				{
					return;
				}
				_prevUpdateTime = value;
				PropertySet(this);
			}
		}

		public HitReactionCumulativeDamageUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
