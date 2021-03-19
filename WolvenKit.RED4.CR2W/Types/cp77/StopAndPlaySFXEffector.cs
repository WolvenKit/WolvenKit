using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopAndPlaySFXEffector : gameEffector
	{
		private CName _sfxToStop;
		private CName _sfxToStart;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("sfxToStop")] 
		public CName SfxToStop
		{
			get => GetProperty(ref _sfxToStop);
			set => SetProperty(ref _sfxToStop, value);
		}

		[Ordinal(1)] 
		[RED("sfxToStart")] 
		public CName SfxToStart
		{
			get => GetProperty(ref _sfxToStart);
			set => SetProperty(ref _sfxToStart, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public StopAndPlaySFXEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
