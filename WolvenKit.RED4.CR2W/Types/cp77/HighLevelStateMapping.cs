using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighLevelStateMapping : ChangeHighLevelStateAbstract
	{
		private CHandle<AIArgumentMapping> _stateNameMapping;

		[Ordinal(0)] 
		[RED("stateNameMapping")] 
		public CHandle<AIArgumentMapping> StateNameMapping
		{
			get => GetProperty(ref _stateNameMapping);
			set => SetProperty(ref _stateNameMapping, value);
		}

		public HighLevelStateMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
