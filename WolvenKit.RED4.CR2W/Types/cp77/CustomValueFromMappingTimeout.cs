using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomValueFromMappingTimeout : AITimeoutCondition
	{
		private CHandle<AIArgumentMapping> _actionTweakIDMapping;

		[Ordinal(1)] 
		[RED("actionTweakIDMapping")] 
		public CHandle<AIArgumentMapping> ActionTweakIDMapping
		{
			get => GetProperty(ref _actionTweakIDMapping);
			set => SetProperty(ref _actionTweakIDMapping, value);
		}

		public CustomValueFromMappingTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
