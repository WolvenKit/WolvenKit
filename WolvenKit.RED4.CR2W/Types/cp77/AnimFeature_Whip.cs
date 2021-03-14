using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Whip : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _pullState;
		private Vector4 _targetPoint;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pullState")] 
		public CInt32 PullState
		{
			get
			{
				if (_pullState == null)
				{
					_pullState = (CInt32) CR2WTypeManager.Create("Int32", "pullState", cr2w, this);
				}
				return _pullState;
			}
			set
			{
				if (_pullState == value)
				{
					return;
				}
				_pullState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetPoint")] 
		public Vector4 TargetPoint
		{
			get
			{
				if (_targetPoint == null)
				{
					_targetPoint = (Vector4) CR2WTypeManager.Create("Vector4", "targetPoint", cr2w, this);
				}
				return _targetPoint;
			}
			set
			{
				if (_targetPoint == value)
				{
					return;
				}
				_targetPoint = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Whip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
