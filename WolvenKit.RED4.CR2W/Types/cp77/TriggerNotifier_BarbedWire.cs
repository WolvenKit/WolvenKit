using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerNotifier_BarbedWire : entTriggerNotifier_Script
	{
		private TweakDBID _attackType;

		[Ordinal(3)] 
		[RED("attackType")] 
		public TweakDBID AttackType
		{
			get
			{
				if (_attackType == null)
				{
					_attackType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackType", cr2w, this);
				}
				return _attackType;
			}
			set
			{
				if (_attackType == value)
				{
					return;
				}
				_attackType = value;
				PropertySet(this);
			}
		}

		public TriggerNotifier_BarbedWire(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
