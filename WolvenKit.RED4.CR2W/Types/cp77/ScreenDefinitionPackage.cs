using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScreenDefinitionPackage : CVariable
	{
		private CHandle<gamedataDeviceUIDefinition_Record> _screenDefinition;
		private CHandle<gamedataWidgetStyle_Record> _style;

		[Ordinal(0)] 
		[RED("screenDefinition")] 
		public CHandle<gamedataDeviceUIDefinition_Record> ScreenDefinition
		{
			get
			{
				if (_screenDefinition == null)
				{
					_screenDefinition = (CHandle<gamedataDeviceUIDefinition_Record>) CR2WTypeManager.Create("handle:gamedataDeviceUIDefinition_Record", "screenDefinition", cr2w, this);
				}
				return _screenDefinition;
			}
			set
			{
				if (_screenDefinition == value)
				{
					return;
				}
				_screenDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("style")] 
		public CHandle<gamedataWidgetStyle_Record> Style
		{
			get
			{
				if (_style == null)
				{
					_style = (CHandle<gamedataWidgetStyle_Record>) CR2WTypeManager.Create("handle:gamedataWidgetStyle_Record", "style", cr2w, this);
				}
				return _style;
			}
			set
			{
				if (_style == value)
				{
					return;
				}
				_style = value;
				PropertySet(this);
			}
		}

		public ScreenDefinitionPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
