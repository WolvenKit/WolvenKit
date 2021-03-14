using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_ProxyMeshDependency : worldEditorDebugColoringSettings
	{
		private CColor _autoColor;
		private CColor _discardColor;

		[Ordinal(0)] 
		[RED("autoColor")] 
		public CColor AutoColor
		{
			get
			{
				if (_autoColor == null)
				{
					_autoColor = (CColor) CR2WTypeManager.Create("Color", "autoColor", cr2w, this);
				}
				return _autoColor;
			}
			set
			{
				if (_autoColor == value)
				{
					return;
				}
				_autoColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("discardColor")] 
		public CColor DiscardColor
		{
			get
			{
				if (_discardColor == null)
				{
					_discardColor = (CColor) CR2WTypeManager.Create("Color", "discardColor", cr2w, this);
				}
				return _discardColor;
			}
			set
			{
				if (_discardColor == value)
				{
					return;
				}
				_discardColor = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_ProxyMeshDependency(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
