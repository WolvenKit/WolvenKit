using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackDoorDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isInDefaultState;
		private gamebbScriptID_Int32 _shutdownModule;
		private gamebbScriptID_Int32 _bootModule;

		[Ordinal(8)] 
		[RED("isInDefaultState")] 
		public gamebbScriptID_Bool IsInDefaultState
		{
			get
			{
				if (_isInDefaultState == null)
				{
					_isInDefaultState = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "isInDefaultState", cr2w, this);
				}
				return _isInDefaultState;
			}
			set
			{
				if (_isInDefaultState == value)
				{
					return;
				}
				_isInDefaultState = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("shutdownModule")] 
		public gamebbScriptID_Int32 ShutdownModule
		{
			get
			{
				if (_shutdownModule == null)
				{
					_shutdownModule = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "shutdownModule", cr2w, this);
				}
				return _shutdownModule;
			}
			set
			{
				if (_shutdownModule == value)
				{
					return;
				}
				_shutdownModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bootModule")] 
		public gamebbScriptID_Int32 BootModule
		{
			get
			{
				if (_bootModule == null)
				{
					_bootModule = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "bootModule", cr2w, this);
				}
				return _bootModule;
			}
			set
			{
				if (_bootModule == value)
				{
					return;
				}
				_bootModule = value;
				PropertySet(this);
			}
		}

		public BackDoorDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
