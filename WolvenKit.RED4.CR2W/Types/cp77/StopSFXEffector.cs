using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopSFXEffector : gameEffector
	{
		private CName _sfxName;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetProperty(ref _sfxName);
			set => SetProperty(ref _sfxName, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public StopSFXEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
