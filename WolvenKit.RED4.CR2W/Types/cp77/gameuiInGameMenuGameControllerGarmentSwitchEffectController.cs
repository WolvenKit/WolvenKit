using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameControllerGarmentSwitchEffectController : CVariable
	{
		private CName _sceneName;
		private CName _effectName;

		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get
			{
				if (_sceneName == null)
				{
					_sceneName = (CName) CR2WTypeManager.Create("CName", "sceneName", cr2w, this);
				}
				return _sceneName;
			}
			set
			{
				if (_sceneName == value)
				{
					return;
				}
				_sceneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		public gameuiInGameMenuGameControllerGarmentSwitchEffectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
