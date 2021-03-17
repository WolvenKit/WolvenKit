using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Bump : animAnimFeature
	{
		private CFloat _direction;
		private CFloat _source;
		private CFloat _intensity;
		private CBool _isBumping;
		private CInt32 _bumpType;

		[Ordinal(0)] 
		[RED("direction")] 
		public CFloat Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CFloat Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		[Ordinal(2)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(3)] 
		[RED("isBumping")] 
		public CBool IsBumping
		{
			get => GetProperty(ref _isBumping);
			set => SetProperty(ref _isBumping, value);
		}

		[Ordinal(4)] 
		[RED("bumpType")] 
		public CInt32 BumpType
		{
			get => GetProperty(ref _bumpType);
			set => SetProperty(ref _bumpType, value);
		}

		public animAnimFeature_Bump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
