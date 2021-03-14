using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayCyberwareCondition : GameplayConditionBase
	{
		private TweakDBID _cyberwareToCheck;

		[Ordinal(1)] 
		[RED("cyberwareToCheck")] 
		public TweakDBID CyberwareToCheck
		{
			get
			{
				if (_cyberwareToCheck == null)
				{
					_cyberwareToCheck = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "cyberwareToCheck", cr2w, this);
				}
				return _cyberwareToCheck;
			}
			set
			{
				if (_cyberwareToCheck == value)
				{
					return;
				}
				_cyberwareToCheck = value;
				PropertySet(this);
			}
		}

		public GameplayCyberwareCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
