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
			get
			{
				if (_actionsConditions == null)
				{
					_actionsConditions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "actionsConditions", cr2w, this);
				}
				return _actionsConditions;
			}
			set
			{
				if (_actionsConditions == value)
				{
					return;
				}
				_actionsConditions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionsWeights")] 
		public CArray<CInt32> ActionsWeights
		{
			get
			{
				if (_actionsWeights == null)
				{
					_actionsWeights = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "actionsWeights", cr2w, this);
				}
				return _actionsWeights;
			}
			set
			{
				if (_actionsWeights == value)
				{
					return;
				}
				_actionsWeights = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lowestWeight")] 
		public CInt32 LowestWeight
		{
			get
			{
				if (_lowestWeight == null)
				{
					_lowestWeight = (CInt32) CR2WTypeManager.Create("Int32", "lowestWeight", cr2w, this);
				}
				return _lowestWeight;
			}
			set
			{
				if (_lowestWeight == value)
				{
					return;
				}
				_lowestWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("selectedActionIndex")] 
		public CInt32 SelectedActionIndex
		{
			get
			{
				if (_selectedActionIndex == null)
				{
					_selectedActionIndex = (CInt32) CR2WTypeManager.Create("Int32", "selectedActionIndex", cr2w, this);
				}
				return _selectedActionIndex;
			}
			set
			{
				if (_selectedActionIndex == value)
				{
					return;
				}
				_selectedActionIndex = value;
				PropertySet(this);
			}
		}

		public ActionWeightManagerDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
