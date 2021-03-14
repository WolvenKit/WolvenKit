using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpiderbotCheckIfFriendlyMoved : AIAutonomousConditions
	{
		private CHandle<AIArgumentMapping> _maxAllowedDelta;

		[Ordinal(0)] 
		[RED("maxAllowedDelta")] 
		public CHandle<AIArgumentMapping> MaxAllowedDelta
		{
			get
			{
				if (_maxAllowedDelta == null)
				{
					_maxAllowedDelta = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "maxAllowedDelta", cr2w, this);
				}
				return _maxAllowedDelta;
			}
			set
			{
				if (_maxAllowedDelta == value)
				{
					return;
				}
				_maxAllowedDelta = value;
				PropertySet(this);
			}
		}

		public AISpiderbotCheckIfFriendlyMoved(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
