using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionWeightManagerDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("actionsConditions")] 
		public CArray<CName> ActionsConditions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("actionsWeights")] 
		public CArray<CInt32> ActionsWeights
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("lowestWeight")] 
		public CInt32 LowestWeight
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("selectedActionIndex")] 
		public CInt32 SelectedActionIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ActionWeightManagerDelegate()
		{
			ActionsConditions = new();
			ActionsWeights = new();
		}
	}
}
