using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayTransformAnimationDeviceOperation : DeviceOperationBase
	{
		private CArray<STransformAnimationData> _transformAnimations;

		[Ordinal(5)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get => GetProperty(ref _transformAnimations);
			set => SetProperty(ref _transformAnimations, value);
		}

		public PlayTransformAnimationDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
