using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorClearUsedAlertedSpotsTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _usedTokens;

		[Ordinal(1)] 
		[RED("usedTokens")] 
		public CHandle<AIArgumentMapping> UsedTokens
		{
			get
			{
				if (_usedTokens == null)
				{
					_usedTokens = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "usedTokens", cr2w, this);
				}
				return _usedTokens;
			}
			set
			{
				if (_usedTokens == value)
				{
					return;
				}
				_usedTokens = value;
				PropertySet(this);
			}
		}

		public AIbehaviorClearUsedAlertedSpotsTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
