using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CrowdRunningAway : animAnimFeature
	{
		private CBool _isRunningAwayFromPlayersCar;

		[Ordinal(0)] 
		[RED("isRunningAwayFromPlayersCar")] 
		public CBool IsRunningAwayFromPlayersCar
		{
			get => GetProperty(ref _isRunningAwayFromPlayersCar);
			set => SetProperty(ref _isRunningAwayFromPlayersCar, value);
		}

		public AnimFeature_CrowdRunningAway(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
