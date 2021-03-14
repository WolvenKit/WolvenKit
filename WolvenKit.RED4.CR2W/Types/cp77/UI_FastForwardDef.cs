using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_FastForwardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _fastForwardAvailable;
		private gamebbScriptID_Bool _fastForwardActive;

		[Ordinal(0)] 
		[RED("FastForwardAvailable")] 
		public gamebbScriptID_Bool FastForwardAvailable
		{
			get
			{
				if (_fastForwardAvailable == null)
				{
					_fastForwardAvailable = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "FastForwardAvailable", cr2w, this);
				}
				return _fastForwardAvailable;
			}
			set
			{
				if (_fastForwardAvailable == value)
				{
					return;
				}
				_fastForwardAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("FastForwardActive")] 
		public gamebbScriptID_Bool FastForwardActive
		{
			get
			{
				if (_fastForwardActive == null)
				{
					_fastForwardActive = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "FastForwardActive", cr2w, this);
				}
				return _fastForwardActive;
			}
			set
			{
				if (_fastForwardActive == value)
				{
					return;
				}
				_fastForwardActive = value;
				PropertySet(this);
			}
		}

		public UI_FastForwardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
