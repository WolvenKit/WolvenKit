using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsBumpEvent : redEvent
	{
		private CEnum<gameinteractionsBumpSide> _side;
		private CEnum<gameinteractionsBumpLocation> _sourceLocation;
		private Vector4 _direction;
		private Vector4 _sourcePosition;
		private CFloat _sourceSquaredDistance;
		private CFloat _sourceSpeed;
		private CBool _isMounted;
		private CFloat _sourceRadius;

		[Ordinal(0)] 
		[RED("side")] 
		public CEnum<gameinteractionsBumpSide> Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}

		[Ordinal(1)] 
		[RED("sourceLocation")] 
		public CEnum<gameinteractionsBumpLocation> SourceLocation
		{
			get => GetProperty(ref _sourceLocation);
			set => SetProperty(ref _sourceLocation, value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(3)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get => GetProperty(ref _sourcePosition);
			set => SetProperty(ref _sourcePosition, value);
		}

		[Ordinal(4)] 
		[RED("sourceSquaredDistance")] 
		public CFloat SourceSquaredDistance
		{
			get => GetProperty(ref _sourceSquaredDistance);
			set => SetProperty(ref _sourceSquaredDistance, value);
		}

		[Ordinal(5)] 
		[RED("sourceSpeed")] 
		public CFloat SourceSpeed
		{
			get => GetProperty(ref _sourceSpeed);
			set => SetProperty(ref _sourceSpeed, value);
		}

		[Ordinal(6)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetProperty(ref _isMounted);
			set => SetProperty(ref _isMounted, value);
		}

		[Ordinal(7)] 
		[RED("sourceRadius")] 
		public CFloat SourceRadius
		{
			get => GetProperty(ref _sourceRadius);
			set => SetProperty(ref _sourceRadius, value);
		}

		public gameinteractionsBumpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
