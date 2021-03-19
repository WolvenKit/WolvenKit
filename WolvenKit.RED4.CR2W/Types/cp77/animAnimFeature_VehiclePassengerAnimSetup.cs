using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_VehiclePassengerAnimSetup : animAnimFeature
	{
		private CBool _enableAdditiveAnim;
		private CFloat _additiveScale;

		[Ordinal(0)] 
		[RED("enableAdditiveAnim")] 
		public CBool EnableAdditiveAnim
		{
			get => GetProperty(ref _enableAdditiveAnim);
			set => SetProperty(ref _enableAdditiveAnim, value);
		}

		[Ordinal(1)] 
		[RED("additiveScale")] 
		public CFloat AdditiveScale
		{
			get => GetProperty(ref _additiveScale);
			set => SetProperty(ref _additiveScale, value);
		}

		public animAnimFeature_VehiclePassengerAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
