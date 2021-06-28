using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionWeightManagerDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CArray<CName> _actionsConditions;
		private CArray<CInt32> _actionsWeights;
		private CInt32 _lowestWeight;
		private CInt32 _selectedActionIndex;

		[Ordinal(0)] 
		[RED("actionsConditions")] 
		public CArray<CName> ActionsConditions
		{
			get => GetProperty(ref _actionsConditions);
			set => SetProperty(ref _actionsConditions, value);
		}

		[Ordinal(1)] 
		[RED("actionsWeights")] 
		public CArray<CInt32> ActionsWeights
		{
			get => GetProperty(ref _actionsWeights);
			set => SetProperty(ref _actionsWeights, value);
		}

		[Ordinal(2)] 
		[RED("lowestWeight")] 
		public CInt32 LowestWeight
		{
			get => GetProperty(ref _lowestWeight);
			set => SetProperty(ref _lowestWeight, value);
		}

		[Ordinal(3)] 
		[RED("selectedActionIndex")] 
		public CInt32 SelectedActionIndex
		{
			get => GetProperty(ref _selectedActionIndex);
			set => SetProperty(ref _selectedActionIndex, value);
		}

		public ActionWeightManagerDelegate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
