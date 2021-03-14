using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionRotateToObjectState : gameActionRotateBaseState
	{
		private wCHandle<gameObject> _targetObject;
		private CBool _completeWhenRotated;

		[Ordinal(11)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get
			{
				if (_targetObject == null)
				{
					_targetObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObject", cr2w, this);
				}
				return _targetObject;
			}
			set
			{
				if (_targetObject == value)
				{
					return;
				}
				_targetObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("completeWhenRotated")] 
		public CBool CompleteWhenRotated
		{
			get
			{
				if (_completeWhenRotated == null)
				{
					_completeWhenRotated = (CBool) CR2WTypeManager.Create("Bool", "completeWhenRotated", cr2w, this);
				}
				return _completeWhenRotated;
			}
			set
			{
				if (_completeWhenRotated == value)
				{
					return;
				}
				_completeWhenRotated = value;
				PropertySet(this);
			}
		}

		public gameActionRotateToObjectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
