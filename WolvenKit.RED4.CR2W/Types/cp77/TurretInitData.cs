using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TurretInitData : IScriptable
	{
		private wCHandle<gameObject> _turret;

		[Ordinal(0)] 
		[RED("turret")] 
		public wCHandle<gameObject> Turret
		{
			get
			{
				if (_turret == null)
				{
					_turret = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "turret", cr2w, this);
				}
				return _turret;
			}
			set
			{
				if (_turret == value)
				{
					return;
				}
				_turret = value;
				PropertySet(this);
			}
		}

		public TurretInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
