using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ButtonPlaySoundView : BaseButtonView
	{
		private CName _soundPrefix;
		private CName _pressSoundName;
		private CName _hoverSoundName;

		[Ordinal(2)] 
		[RED("SoundPrefix")] 
		public CName SoundPrefix
		{
			get => GetProperty(ref _soundPrefix);
			set => SetProperty(ref _soundPrefix, value);
		}

		[Ordinal(3)] 
		[RED("PressSoundName")] 
		public CName PressSoundName
		{
			get => GetProperty(ref _pressSoundName);
			set => SetProperty(ref _pressSoundName, value);
		}

		[Ordinal(4)] 
		[RED("HoverSoundName")] 
		public CName HoverSoundName
		{
			get => GetProperty(ref _hoverSoundName);
			set => SetProperty(ref _hoverSoundName, value);
		}

		public ButtonPlaySoundView(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
