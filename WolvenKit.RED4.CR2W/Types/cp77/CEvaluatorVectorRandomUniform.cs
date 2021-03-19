using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorRandomUniform : IEvaluatorVector
	{
		private Vector4 _min;
		private Vector4 _max;
		private CBool _lockX;
		private CBool _lockY;
		private CBool _lockZ;
		private CBool _lockW;

		[Ordinal(2)] 
		[RED("min")] 
		public Vector4 Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(3)] 
		[RED("max")] 
		public Vector4 Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		[Ordinal(4)] 
		[RED("lockX")] 
		public CBool LockX
		{
			get => GetProperty(ref _lockX);
			set => SetProperty(ref _lockX, value);
		}

		[Ordinal(5)] 
		[RED("lockY")] 
		public CBool LockY
		{
			get => GetProperty(ref _lockY);
			set => SetProperty(ref _lockY, value);
		}

		[Ordinal(6)] 
		[RED("lockZ")] 
		public CBool LockZ
		{
			get => GetProperty(ref _lockZ);
			set => SetProperty(ref _lockZ, value);
		}

		[Ordinal(7)] 
		[RED("lockW")] 
		public CBool LockW
		{
			get => GetProperty(ref _lockW);
			set => SetProperty(ref _lockW, value);
		}

		public CEvaluatorVectorRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
