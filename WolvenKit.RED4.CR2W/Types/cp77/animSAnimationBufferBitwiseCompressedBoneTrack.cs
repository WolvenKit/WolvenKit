using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSAnimationBufferBitwiseCompressedBoneTrack : CVariable
	{
		private animSAnimationBufferBitwiseCompressedData _position;
		private animSAnimationBufferBitwiseCompressedData _orientation;
		private animSAnimationBufferBitwiseCompressedData _scale;

		[Ordinal(0)] 
		[RED("position")] 
		public animSAnimationBufferBitwiseCompressedData Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("orientation")] 
		public animSAnimationBufferBitwiseCompressedData Orientation
		{
			get => GetProperty(ref _orientation);
			set => SetProperty(ref _orientation, value);
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public animSAnimationBufferBitwiseCompressedData Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		public animSAnimationBufferBitwiseCompressedBoneTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
