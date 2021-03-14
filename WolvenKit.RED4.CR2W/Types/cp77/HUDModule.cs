using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDModule : IScriptable
	{
		private wCHandle<HUDManager> _hud;
		private CEnum<ModuleState> _state;
		private CArray<CHandle<ModuleInstance>> _instancesList;

		[Ordinal(0)] 
		[RED("hud")] 
		public wCHandle<HUDManager> Hud
		{
			get
			{
				if (_hud == null)
				{
					_hud = (wCHandle<HUDManager>) CR2WTypeManager.Create("whandle:HUDManager", "hud", cr2w, this);
				}
				return _hud;
			}
			set
			{
				if (_hud == value)
				{
					return;
				}
				_hud = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<ModuleState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ModuleState>) CR2WTypeManager.Create("ModuleState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instancesList")] 
		public CArray<CHandle<ModuleInstance>> InstancesList
		{
			get
			{
				if (_instancesList == null)
				{
					_instancesList = (CArray<CHandle<ModuleInstance>>) CR2WTypeManager.Create("array:handle:ModuleInstance", "instancesList", cr2w, this);
				}
				return _instancesList;
			}
			set
			{
				if (_instancesList == value)
				{
					return;
				}
				_instancesList = value;
				PropertySet(this);
			}
		}

		public HUDModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
