using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_PlaySound : gameTransformAnimationTrackItemImpl
	{
		private CName _soundName;
		private CBool _unique;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetProperty(ref _soundName);
			set => SetProperty(ref _soundName, value);
		}

		[Ordinal(1)] 
		[RED("unique")] 
		public CBool Unique
		{
			get => GetProperty(ref _unique);
			set => SetProperty(ref _unique, value);
		}

		public gameTransformAnimation_PlaySound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
