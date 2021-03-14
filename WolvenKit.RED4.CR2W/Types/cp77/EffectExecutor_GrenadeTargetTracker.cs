using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_GrenadeTargetTracker : gameEffectExecutor_Scripted
	{
		private CArray<CName> _potentialTargetSlots;

		[Ordinal(1)] 
		[RED("potentialTargetSlots")] 
		public CArray<CName> PotentialTargetSlots
		{
			get
			{
				if (_potentialTargetSlots == null)
				{
					_potentialTargetSlots = (CArray<CName>) CR2WTypeManager.Create("array:CName", "potentialTargetSlots", cr2w, this);
				}
				return _potentialTargetSlots;
			}
			set
			{
				if (_potentialTargetSlots == value)
				{
					return;
				}
				_potentialTargetSlots = value;
				PropertySet(this);
			}
		}

		public EffectExecutor_GrenadeTargetTracker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
