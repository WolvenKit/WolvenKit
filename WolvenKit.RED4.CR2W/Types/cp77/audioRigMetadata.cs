using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRigMetadata : audioAudioMetadata
	{
		private CArray<CName> _positionBones;
		private CName _defaultBone;

		[Ordinal(1)] 
		[RED("positionBones")] 
		public CArray<CName> PositionBones
		{
			get => GetProperty(ref _positionBones);
			set => SetProperty(ref _positionBones, value);
		}

		[Ordinal(2)] 
		[RED("defaultBone")] 
		public CName DefaultBone
		{
			get => GetProperty(ref _defaultBone);
			set => SetProperty(ref _defaultBone, value);
		}

		public audioRigMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
