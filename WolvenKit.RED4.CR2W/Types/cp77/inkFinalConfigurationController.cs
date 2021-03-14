using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFinalConfigurationController : inkWidgetLogicController
	{
		private CEnum<inkFinalConfigurationVisibility> _visibilityFlag;

		[Ordinal(1)] 
		[RED("visibilityFlag")] 
		public CEnum<inkFinalConfigurationVisibility> VisibilityFlag
		{
			get
			{
				if (_visibilityFlag == null)
				{
					_visibilityFlag = (CEnum<inkFinalConfigurationVisibility>) CR2WTypeManager.Create("inkFinalConfigurationVisibility", "visibilityFlag", cr2w, this);
				}
				return _visibilityFlag;
			}
			set
			{
				if (_visibilityFlag == value)
				{
					return;
				}
				_visibilityFlag = value;
				PropertySet(this);
			}
		}

		public inkFinalConfigurationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
