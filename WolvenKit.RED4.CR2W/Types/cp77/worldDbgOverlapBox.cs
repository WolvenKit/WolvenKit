using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDbgOverlapBox : CVariable
	{
		private Box _box;
		private Transform _transform;
		private CUInt32 _level;
		private CBool _isHit;

		[Ordinal(0)] 
		[RED("box")] 
		public Box Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CUInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(3)] 
		[RED("isHit")] 
		public CBool IsHit
		{
			get => GetProperty(ref _isHit);
			set => SetProperty(ref _isHit, value);
		}

		public worldDbgOverlapBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
