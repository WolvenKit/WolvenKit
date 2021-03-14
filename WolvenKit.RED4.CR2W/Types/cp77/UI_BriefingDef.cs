using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_BriefingDef : gamebbScriptDefinition
	{
		private gamebbScriptID_String _briefingToOpen;
		private gamebbScriptID_Variant _briefingSize;
		private gamebbScriptID_Variant _briefingAlignment;

		[Ordinal(0)] 
		[RED("BriefingToOpen")] 
		public gamebbScriptID_String BriefingToOpen
		{
			get
			{
				if (_briefingToOpen == null)
				{
					_briefingToOpen = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "BriefingToOpen", cr2w, this);
				}
				return _briefingToOpen;
			}
			set
			{
				if (_briefingToOpen == value)
				{
					return;
				}
				_briefingToOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("BriefingSize")] 
		public gamebbScriptID_Variant BriefingSize
		{
			get
			{
				if (_briefingSize == null)
				{
					_briefingSize = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "BriefingSize", cr2w, this);
				}
				return _briefingSize;
			}
			set
			{
				if (_briefingSize == value)
				{
					return;
				}
				_briefingSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("BriefingAlignment")] 
		public gamebbScriptID_Variant BriefingAlignment
		{
			get
			{
				if (_briefingAlignment == null)
				{
					_briefingAlignment = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "BriefingAlignment", cr2w, this);
				}
				return _briefingAlignment;
			}
			set
			{
				if (_briefingAlignment == value)
				{
					return;
				}
				_briefingAlignment = value;
				PropertySet(this);
			}
		}

		public UI_BriefingDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
