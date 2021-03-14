using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private MovableDeviceSetup _movableDeviceSetup;
		private CHandle<DemolitionContainer> _movableDeviceSkillChecks;

		[Ordinal(103)] 
		[RED("MovableDeviceSetup")] 
		public MovableDeviceSetup MovableDeviceSetup
		{
			get
			{
				if (_movableDeviceSetup == null)
				{
					_movableDeviceSetup = (MovableDeviceSetup) CR2WTypeManager.Create("MovableDeviceSetup", "MovableDeviceSetup", cr2w, this);
				}
				return _movableDeviceSetup;
			}
			set
			{
				if (_movableDeviceSetup == value)
				{
					return;
				}
				_movableDeviceSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("movableDeviceSkillChecks")] 
		public CHandle<DemolitionContainer> MovableDeviceSkillChecks
		{
			get
			{
				if (_movableDeviceSkillChecks == null)
				{
					_movableDeviceSkillChecks = (CHandle<DemolitionContainer>) CR2WTypeManager.Create("handle:DemolitionContainer", "movableDeviceSkillChecks", cr2w, this);
				}
				return _movableDeviceSkillChecks;
			}
			set
			{
				if (_movableDeviceSkillChecks == value)
				{
					return;
				}
				_movableDeviceSkillChecks = value;
				PropertySet(this);
			}
		}

		public MovableDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
