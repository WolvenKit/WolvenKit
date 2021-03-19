using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectSingleFilter_BlackboardBoolCondition : gameEffectObjectSingleFilter
	{
		private gameEffectInputParameter_Bool _parameter;
		private CHandle<gameEffectObjectSingleFilter> _filter;

		[Ordinal(0)] 
		[RED("parameter")] 
		public gameEffectInputParameter_Bool Parameter
		{
			get => GetProperty(ref _parameter);
			set => SetProperty(ref _parameter, value);
		}

		[Ordinal(1)] 
		[RED("filter")] 
		public CHandle<gameEffectObjectSingleFilter> Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}

		public gameEffectObjectSingleFilter_BlackboardBoolCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
