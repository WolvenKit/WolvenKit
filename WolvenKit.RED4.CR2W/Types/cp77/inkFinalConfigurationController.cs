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
			get => GetProperty(ref _visibilityFlag);
			set => SetProperty(ref _visibilityFlag, value);
		}

		public inkFinalConfigurationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
