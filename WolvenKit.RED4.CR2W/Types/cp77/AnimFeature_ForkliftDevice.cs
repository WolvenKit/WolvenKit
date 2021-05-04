using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ForkliftDevice : animAnimFeature
	{
		private CBool _isUp;
		private CBool _isDown;
		private CBool _distract;

		[Ordinal(0)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get => GetProperty(ref _isUp);
			set => SetProperty(ref _isUp, value);
		}

		[Ordinal(1)] 
		[RED("isDown")] 
		public CBool IsDown
		{
			get => GetProperty(ref _isDown);
			set => SetProperty(ref _isDown, value);
		}

		[Ordinal(2)] 
		[RED("distract")] 
		public CBool Distract
		{
			get => GetProperty(ref _distract);
			set => SetProperty(ref _distract, value);
		}

		public AnimFeature_ForkliftDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
