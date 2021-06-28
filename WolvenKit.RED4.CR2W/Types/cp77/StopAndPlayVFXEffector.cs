using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StopAndPlayVFXEffector : gameEffector
	{
		private CName _vfxToStop;
		private CName _vfxToStart;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("vfxToStop")] 
		public CName VfxToStop
		{
			get => GetProperty(ref _vfxToStop);
			set => SetProperty(ref _vfxToStop, value);
		}

		[Ordinal(1)] 
		[RED("vfxToStart")] 
		public CName VfxToStart
		{
			get => GetProperty(ref _vfxToStart);
			set => SetProperty(ref _vfxToStart, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public StopAndPlayVFXEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
