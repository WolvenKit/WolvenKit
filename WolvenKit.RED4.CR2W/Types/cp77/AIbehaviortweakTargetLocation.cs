using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviortweakTargetLocation : CVariable
	{
		private wCHandle<gameObject> _object;
		private Vector3 _position;
		private Vector3 _speed;
		private AIObjectId _coverId;
		private CBool _hasPosition;
		private CBool _hasSpeed;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<gameObject> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public Vector3 Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(3)] 
		[RED("coverId")] 
		public AIObjectId CoverId
		{
			get => GetProperty(ref _coverId);
			set => SetProperty(ref _coverId, value);
		}

		[Ordinal(4)] 
		[RED("hasPosition")] 
		public CBool HasPosition
		{
			get => GetProperty(ref _hasPosition);
			set => SetProperty(ref _hasPosition, value);
		}

		[Ordinal(5)] 
		[RED("hasSpeed")] 
		public CBool HasSpeed
		{
			get => GetProperty(ref _hasSpeed);
			set => SetProperty(ref _hasSpeed, value);
		}

		public AIbehaviortweakTargetLocation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
