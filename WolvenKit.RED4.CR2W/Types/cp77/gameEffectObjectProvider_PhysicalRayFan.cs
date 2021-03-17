using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_PhysicalRayFan : gameEffectObjectProvider_PhysicalRay
	{
		private gameEffectInputParameter_Float _inputMinRayAngleDiff;

		[Ordinal(5)] 
		[RED("inputMinRayAngleDiff")] 
		public gameEffectInputParameter_Float InputMinRayAngleDiff
		{
			get => GetProperty(ref _inputMinRayAngleDiff);
			set => SetProperty(ref _inputMinRayAngleDiff, value);
		}

		public gameEffectObjectProvider_PhysicalRayFan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
