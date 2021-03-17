using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_WallRun : animAnimFeature
	{
		private CBool _wallOnRightSide;
		private Vector4 _wallPosition;
		private Vector4 _wallNormal;

		[Ordinal(0)] 
		[RED("wallOnRightSide")] 
		public CBool WallOnRightSide
		{
			get => GetProperty(ref _wallOnRightSide);
			set => SetProperty(ref _wallOnRightSide, value);
		}

		[Ordinal(1)] 
		[RED("wallPosition")] 
		public Vector4 WallPosition
		{
			get => GetProperty(ref _wallPosition);
			set => SetProperty(ref _wallPosition, value);
		}

		[Ordinal(2)] 
		[RED("wallNormal")] 
		public Vector4 WallNormal
		{
			get => GetProperty(ref _wallNormal);
			set => SetProperty(ref _wallNormal, value);
		}

		public animAnimFeature_WallRun(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
