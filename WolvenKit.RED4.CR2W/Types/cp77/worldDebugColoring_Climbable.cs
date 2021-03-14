using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Climbable : worldEditorDebugColoringSettings
	{
		private CColor _climbableColour;
		private CColor _notClimbableColour;

		[Ordinal(0)] 
		[RED("climbableColour")] 
		public CColor ClimbableColour
		{
			get
			{
				if (_climbableColour == null)
				{
					_climbableColour = (CColor) CR2WTypeManager.Create("Color", "climbableColour", cr2w, this);
				}
				return _climbableColour;
			}
			set
			{
				if (_climbableColour == value)
				{
					return;
				}
				_climbableColour = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("notClimbableColour")] 
		public CColor NotClimbableColour
		{
			get
			{
				if (_notClimbableColour == null)
				{
					_notClimbableColour = (CColor) CR2WTypeManager.Create("Color", "notClimbableColour", cr2w, this);
				}
				return _notClimbableColour;
			}
			set
			{
				if (_notClimbableColour == value)
				{
					return;
				}
				_notClimbableColour = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_Climbable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
