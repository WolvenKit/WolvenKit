using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestVisualDestructionEvent : redEvent
	{
		private CBool _accumulate;
		private CFloat _frontLeft;
		private CFloat _frontRight;
		private CFloat _front;
		private CFloat _right;
		private CFloat _left;
		private CFloat _backLeft;
		private CFloat _backRight;
		private CFloat _back;
		private CFloat _roof;

		[Ordinal(0)] 
		[RED("accumulate")] 
		public CBool Accumulate
		{
			get => GetProperty(ref _accumulate);
			set => SetProperty(ref _accumulate, value);
		}

		[Ordinal(1)] 
		[RED("frontLeft")] 
		public CFloat FrontLeft
		{
			get => GetProperty(ref _frontLeft);
			set => SetProperty(ref _frontLeft, value);
		}

		[Ordinal(2)] 
		[RED("frontRight")] 
		public CFloat FrontRight
		{
			get => GetProperty(ref _frontRight);
			set => SetProperty(ref _frontRight, value);
		}

		[Ordinal(3)] 
		[RED("front")] 
		public CFloat Front
		{
			get => GetProperty(ref _front);
			set => SetProperty(ref _front, value);
		}

		[Ordinal(4)] 
		[RED("right")] 
		public CFloat Right
		{
			get => GetProperty(ref _right);
			set => SetProperty(ref _right, value);
		}

		[Ordinal(5)] 
		[RED("left")] 
		public CFloat Left
		{
			get => GetProperty(ref _left);
			set => SetProperty(ref _left, value);
		}

		[Ordinal(6)] 
		[RED("backLeft")] 
		public CFloat BackLeft
		{
			get => GetProperty(ref _backLeft);
			set => SetProperty(ref _backLeft, value);
		}

		[Ordinal(7)] 
		[RED("backRight")] 
		public CFloat BackRight
		{
			get => GetProperty(ref _backRight);
			set => SetProperty(ref _backRight, value);
		}

		[Ordinal(8)] 
		[RED("back")] 
		public CFloat Back
		{
			get => GetProperty(ref _back);
			set => SetProperty(ref _back, value);
		}

		[Ordinal(9)] 
		[RED("roof")] 
		public CFloat Roof
		{
			get => GetProperty(ref _roof);
			set => SetProperty(ref _roof, value);
		}

		public VehicleQuestVisualDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
