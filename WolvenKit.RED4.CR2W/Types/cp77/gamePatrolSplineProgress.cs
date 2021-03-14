using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePatrolSplineProgress : ISerializable
	{
		private CArray<gamePatrolSplineControlPoint> _currentControlPoints;
		private CFloat _entrySplineParam;
		private CUInt32 _controlPointIndex;

		[Ordinal(0)] 
		[RED("currentControlPoints")] 
		public CArray<gamePatrolSplineControlPoint> CurrentControlPoints
		{
			get
			{
				if (_currentControlPoints == null)
				{
					_currentControlPoints = (CArray<gamePatrolSplineControlPoint>) CR2WTypeManager.Create("array:gamePatrolSplineControlPoint", "currentControlPoints", cr2w, this);
				}
				return _currentControlPoints;
			}
			set
			{
				if (_currentControlPoints == value)
				{
					return;
				}
				_currentControlPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entrySplineParam")] 
		public CFloat EntrySplineParam
		{
			get
			{
				if (_entrySplineParam == null)
				{
					_entrySplineParam = (CFloat) CR2WTypeManager.Create("Float", "entrySplineParam", cr2w, this);
				}
				return _entrySplineParam;
			}
			set
			{
				if (_entrySplineParam == value)
				{
					return;
				}
				_entrySplineParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("controlPointIndex")] 
		public CUInt32 ControlPointIndex
		{
			get
			{
				if (_controlPointIndex == null)
				{
					_controlPointIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "controlPointIndex", cr2w, this);
				}
				return _controlPointIndex;
			}
			set
			{
				if (_controlPointIndex == value)
				{
					return;
				}
				_controlPointIndex = value;
				PropertySet(this);
			}
		}

		public gamePatrolSplineProgress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
