using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionWeightCondition : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _selectedActionIndex;
		private CInt32 _thisIndex;

		[Ordinal(0)] 
		[RED("selectedActionIndex")] 
		public CHandle<AIArgumentMapping> SelectedActionIndex
		{
			get => GetProperty(ref _selectedActionIndex);
			set => SetProperty(ref _selectedActionIndex, value);
		}

		[Ordinal(1)] 
		[RED("thisIndex")] 
		public CInt32 ThisIndex
		{
			get => GetProperty(ref _thisIndex);
			set => SetProperty(ref _thisIndex, value);
		}

		public ActionWeightCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
