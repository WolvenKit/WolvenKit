using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ObjectTagExt : worldEditorDebugColoringSettings
	{
		private CEnum<worldObjectTagExt> _tag;
		private CColor _color;

		[Ordinal(0)] 
		[RED("tag")] 
		public CEnum<worldObjectTagExt> Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CEnum<worldObjectTagExt>) CR2WTypeManager.Create("worldObjectTagExt", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_ObjectTagExt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
