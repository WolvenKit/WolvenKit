using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MoveTo : animAnimFeature
	{
		private Vector4 _initialFwdVector;
		private Vector4 _targetPositionWs;
		private Vector4 _targetDirectionWs;
		private CFloat _timeToMove;

		[Ordinal(0)] 
		[RED("initialFwdVector")] 
		public Vector4 InitialFwdVector
		{
			get
			{
				if (_initialFwdVector == null)
				{
					_initialFwdVector = (Vector4) CR2WTypeManager.Create("Vector4", "initialFwdVector", cr2w, this);
				}
				return _initialFwdVector;
			}
			set
			{
				if (_initialFwdVector == value)
				{
					return;
				}
				_initialFwdVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetPositionWs")] 
		public Vector4 TargetPositionWs
		{
			get
			{
				if (_targetPositionWs == null)
				{
					_targetPositionWs = (Vector4) CR2WTypeManager.Create("Vector4", "targetPositionWs", cr2w, this);
				}
				return _targetPositionWs;
			}
			set
			{
				if (_targetPositionWs == value)
				{
					return;
				}
				_targetPositionWs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetDirectionWs")] 
		public Vector4 TargetDirectionWs
		{
			get
			{
				if (_targetDirectionWs == null)
				{
					_targetDirectionWs = (Vector4) CR2WTypeManager.Create("Vector4", "targetDirectionWs", cr2w, this);
				}
				return _targetDirectionWs;
			}
			set
			{
				if (_targetDirectionWs == value)
				{
					return;
				}
				_targetDirectionWs = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeToMove")] 
		public CFloat TimeToMove
		{
			get
			{
				if (_timeToMove == null)
				{
					_timeToMove = (CFloat) CR2WTypeManager.Create("Float", "timeToMove", cr2w, this);
				}
				return _timeToMove;
			}
			set
			{
				if (_timeToMove == value)
				{
					return;
				}
				_timeToMove = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_MoveTo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
