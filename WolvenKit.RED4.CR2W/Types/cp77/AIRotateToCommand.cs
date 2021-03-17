using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRotateToCommand : AIMoveCommand
	{
		private AIPositionSpec _target;
		private CFloat _angleTolerance;
		private CFloat _angleOffset;
		private CFloat _speed;

		[Ordinal(7)] 
		[RED("target")] 
		public AIPositionSpec Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(8)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get => GetProperty(ref _angleTolerance);
			set => SetProperty(ref _angleTolerance, value);
		}

		[Ordinal(9)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(10)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		public AIRotateToCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
