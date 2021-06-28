using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_AnimatedDevice : animAnimFeature
	{
		private CBool _isOn;
		private CBool _isOff;

		[Ordinal(0)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetProperty(ref _isOn);
			set => SetProperty(ref _isOn, value);
		}

		[Ordinal(1)] 
		[RED("isOff")] 
		public CBool IsOff
		{
			get => GetProperty(ref _isOff);
			set => SetProperty(ref _isOff, value);
		}

		public AnimFeature_AnimatedDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
