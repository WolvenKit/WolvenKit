using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InVehicleCombatDecorator : AIVehicleTaskAbstract
	{
		private wCHandle<gameObject> _targetToChase;

		[Ordinal(0)] 
		[RED("targetToChase")] 
		public wCHandle<gameObject> TargetToChase
		{
			get
			{
				if (_targetToChase == null)
				{
					_targetToChase = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetToChase", cr2w, this);
				}
				return _targetToChase;
			}
			set
			{
				if (_targetToChase == value)
				{
					return;
				}
				_targetToChase = value;
				PropertySet(this);
			}
		}

		public InVehicleCombatDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
