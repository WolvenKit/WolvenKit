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
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		[Ordinal(12)] 
		[RED("completeWhenRotated")] 
		public CBool CompleteWhenRotated
		{
			get => GetProperty(ref _completeWhenRotated);
			set => SetProperty(ref _completeWhenRotated, value);
		}

		public gameActionRotateToObjectState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
