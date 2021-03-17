using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_OrientationVector : animIAnimNodeSourceChannel_Vector
	{
		private animTransformIndex _transformIndex;
		private animTransformIndex _inputTransformIndex;
		private Vector3 _up;

		[Ordinal(0)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(1)] 
		[RED("inputTransformIndex")] 
		public animTransformIndex InputTransformIndex
		{
			get => GetProperty(ref _inputTransformIndex);
			set => SetProperty(ref _inputTransformIndex, value);
		}

		[Ordinal(2)] 
		[RED("up")] 
		public Vector3 Up
		{
			get => GetProperty(ref _up);
			set => SetProperty(ref _up, value);
		}

		public animAnimNodeSourceChannel_OrientationVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
