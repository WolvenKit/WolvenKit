using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RagdollState : animAnimFeature
	{
		private CBool _isActive;
		private CFloat _hipsPolePitch;
		private CFloat _speed;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("hipsPolePitch")] 
		public CFloat HipsPolePitch
		{
			get => GetProperty(ref _hipsPolePitch);
			set => SetProperty(ref _hipsPolePitch, value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		public AnimFeature_RagdollState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
