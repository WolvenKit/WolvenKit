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
			get => GetProperty(ref _turret);
			set => SetProperty(ref _turret, value);
		}

		public TurretInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
