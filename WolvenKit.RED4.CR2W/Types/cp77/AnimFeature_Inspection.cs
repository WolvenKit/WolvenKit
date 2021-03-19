using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Inspection : animAnimFeature
	{
		private CInt32 _activeInspectionStage;
		private CFloat _rotationX;
		private CFloat _rotationY;
		private CFloat _offsetX;
		private CFloat _offsetY;

		[Ordinal(0)] 
		[RED("activeInspectionStage")] 
		public CInt32 ActiveInspectionStage
		{
			get => GetProperty(ref _activeInspectionStage);
			set => SetProperty(ref _activeInspectionStage, value);
		}

		[Ordinal(1)] 
		[RED("rotationX")] 
		public CFloat RotationX
		{
			get => GetProperty(ref _rotationX);
			set => SetProperty(ref _rotationX, value);
		}

		[Ordinal(2)] 
		[RED("rotationY")] 
		public CFloat RotationY
		{
			get => GetProperty(ref _rotationY);
			set => SetProperty(ref _rotationY, value);
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get => GetProperty(ref _offsetX);
			set => SetProperty(ref _offsetX, value);
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get => GetProperty(ref _offsetY);
			set => SetProperty(ref _offsetY, value);
		}

		public AnimFeature_Inspection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
