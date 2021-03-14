using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_PhysicalRay : gameEffectObjectProvider
	{
		private gameEffectInputParameter_Vector _inputPosition;
		private gameEffectInputParameter_Vector _inputForward;
		private gameEffectInputParameter_Float _inputRange;
		private gameEffectOutputParameter_Vector _outputRaycastEnd;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("inputPosition")] 
		public gameEffectInputParameter_Vector InputPosition
		{
			get
			{
				if (_inputPosition == null)
				{
					_inputPosition = (gameEffectInputParameter_Vector) CR2WTypeManager.Create("gameEffectInputParameter_Vector", "inputPosition", cr2w, this);
				}
				return _inputPosition;
			}
			set
			{
				if (_inputPosition == value)
				{
					return;
				}
				_inputPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inputForward")] 
		public gameEffectInputParameter_Vector InputForward
		{
			get
			{
				if (_inputForward == null)
				{
					_inputForward = (gameEffectInputParameter_Vector) CR2WTypeManager.Create("gameEffectInputParameter_Vector", "inputForward", cr2w, this);
				}
				return _inputForward;
			}
			set
			{
				if (_inputForward == value)
				{
					return;
				}
				_inputForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputRange")] 
		public gameEffectInputParameter_Float InputRange
		{
			get
			{
				if (_inputRange == null)
				{
					_inputRange = (gameEffectInputParameter_Float) CR2WTypeManager.Create("gameEffectInputParameter_Float", "inputRange", cr2w, this);
				}
				return _inputRange;
			}
			set
			{
				if (_inputRange == value)
				{
					return;
				}
				_inputRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outputRaycastEnd")] 
		public gameEffectOutputParameter_Vector OutputRaycastEnd
		{
			get
			{
				if (_outputRaycastEnd == null)
				{
					_outputRaycastEnd = (gameEffectOutputParameter_Vector) CR2WTypeManager.Create("gameEffectOutputParameter_Vector", "outputRaycastEnd", cr2w, this);
				}
				return _outputRaycastEnd;
			}
			set
			{
				if (_outputRaycastEnd == value)
				{
					return;
				}
				_outputRaycastEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectProvider_PhysicalRay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
