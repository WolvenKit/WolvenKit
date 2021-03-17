using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleState : animAnimFeatureMarkUnstable
	{
		private CBool _tppEnabled;

		[Ordinal(0)] 
		[RED("tppEnabled")] 
		public CBool TppEnabled
		{
			get => GetProperty(ref _tppEnabled);
			set => SetProperty(ref _tppEnabled, value);
		}

		public AnimFeature_VehicleState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
