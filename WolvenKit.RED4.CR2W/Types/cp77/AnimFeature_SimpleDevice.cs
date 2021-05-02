using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SimpleDevice : animAnimFeatureMarkUnstable
	{
		private CBool _isOpen;
		private CBool _isOpenLeft;
		private CBool _isOpenRight;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(1)] 
		[RED("isOpenLeft")] 
		public CBool IsOpenLeft
		{
			get => GetProperty(ref _isOpenLeft);
			set => SetProperty(ref _isOpenLeft, value);
		}

		[Ordinal(2)] 
		[RED("isOpenRight")] 
		public CBool IsOpenRight
		{
			get => GetProperty(ref _isOpenRight);
			set => SetProperty(ref _isOpenRight, value);
		}

		public AnimFeature_SimpleDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
