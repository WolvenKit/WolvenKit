using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DroneActionAltitudeOffset : animAnimFeature
	{
		private CFloat _desiredOffset;

		[Ordinal(0)] 
		[RED("desiredOffset")] 
		public CFloat DesiredOffset
		{
			get => GetProperty(ref _desiredOffset);
			set => SetProperty(ref _desiredOffset, value);
		}

		public AnimFeature_DroneActionAltitudeOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
