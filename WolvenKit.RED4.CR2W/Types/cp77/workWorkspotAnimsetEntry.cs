using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotAnimsetEntry : CVariable
	{
		private raRef<animRig> _rig;
		private animAnimSetup _animations;
		private CArray<rRef<animAnimSet>> _loadingHandles;

		[Ordinal(0)] 
		[RED("rig")] 
		public raRef<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(2)] 
		[RED("loadingHandles")] 
		public CArray<rRef<animAnimSet>> LoadingHandles
		{
			get => GetProperty(ref _loadingHandles);
			set => SetProperty(ref _loadingHandles, value);
		}

		public workWorkspotAnimsetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
