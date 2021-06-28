using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entFacialCustomizationComponent : entIComponent
	{
		private CBool _debugIgnoreComponent;
		private raRef<animFacialCustomizationSet> _customizationSet;
		private CUInt32 _eyes;
		private CUInt32 _nose;
		private CUInt32 _mouth;
		private CUInt32 _jaw;
		private CUInt32 _ears;

		[Ordinal(3)] 
		[RED("debugIgnoreComponent")] 
		public CBool DebugIgnoreComponent
		{
			get => GetProperty(ref _debugIgnoreComponent);
			set => SetProperty(ref _debugIgnoreComponent, value);
		}

		[Ordinal(4)] 
		[RED("customizationSet")] 
		public raRef<animFacialCustomizationSet> CustomizationSet
		{
			get => GetProperty(ref _customizationSet);
			set => SetProperty(ref _customizationSet, value);
		}

		[Ordinal(5)] 
		[RED("eyes")] 
		public CUInt32 Eyes
		{
			get => GetProperty(ref _eyes);
			set => SetProperty(ref _eyes, value);
		}

		[Ordinal(6)] 
		[RED("nose")] 
		public CUInt32 Nose
		{
			get => GetProperty(ref _nose);
			set => SetProperty(ref _nose, value);
		}

		[Ordinal(7)] 
		[RED("mouth")] 
		public CUInt32 Mouth
		{
			get => GetProperty(ref _mouth);
			set => SetProperty(ref _mouth, value);
		}

		[Ordinal(8)] 
		[RED("jaw")] 
		public CUInt32 Jaw
		{
			get => GetProperty(ref _jaw);
			set => SetProperty(ref _jaw, value);
		}

		[Ordinal(9)] 
		[RED("ears")] 
		public CUInt32 Ears
		{
			get => GetProperty(ref _ears);
			set => SetProperty(ref _ears, value);
		}

		public entFacialCustomizationComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
