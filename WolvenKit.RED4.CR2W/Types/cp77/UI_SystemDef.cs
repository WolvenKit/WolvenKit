using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_SystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _isInMenu;
		private gamebbScriptID_Bool _circularBlurEnabled;
		private gamebbScriptID_Float _circularBlurBlendTime;
		private gamebbScriptID_Variant _trackedMappin;

		[Ordinal(0)] 
		[RED("IsInMenu")] 
		public gamebbScriptID_Bool IsInMenu
		{
			get
			{
				if (_isInMenu == null)
				{
					_isInMenu = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsInMenu", cr2w, this);
				}
				return _isInMenu;
			}
			set
			{
				if (_isInMenu == value)
				{
					return;
				}
				_isInMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("CircularBlurEnabled")] 
		public gamebbScriptID_Bool CircularBlurEnabled
		{
			get
			{
				if (_circularBlurEnabled == null)
				{
					_circularBlurEnabled = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "CircularBlurEnabled", cr2w, this);
				}
				return _circularBlurEnabled;
			}
			set
			{
				if (_circularBlurEnabled == value)
				{
					return;
				}
				_circularBlurEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("CircularBlurBlendTime")] 
		public gamebbScriptID_Float CircularBlurBlendTime
		{
			get
			{
				if (_circularBlurBlendTime == null)
				{
					_circularBlurBlendTime = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "CircularBlurBlendTime", cr2w, this);
				}
				return _circularBlurBlendTime;
			}
			set
			{
				if (_circularBlurBlendTime == value)
				{
					return;
				}
				_circularBlurBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("TrackedMappin")] 
		public gamebbScriptID_Variant TrackedMappin
		{
			get
			{
				if (_trackedMappin == null)
				{
					_trackedMappin = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "TrackedMappin", cr2w, this);
				}
				return _trackedMappin;
			}
			set
			{
				if (_trackedMappin == value)
				{
					return;
				}
				_trackedMappin = value;
				PropertySet(this);
			}
		}

		public UI_SystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
