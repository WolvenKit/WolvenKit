using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialsMap : audioAudioMetadata
	{
		private CFloat _closestDecalDetectionRadius;
		private CArray<audioFootstepDecalMaterialEntry> _entries;

		[Ordinal(1)] 
		[RED("closestDecalDetectionRadius")] 
		public CFloat ClosestDecalDetectionRadius
		{
			get => GetProperty(ref _closestDecalDetectionRadius);
			set => SetProperty(ref _closestDecalDetectionRadius, value);
		}

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<audioFootstepDecalMaterialEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public audioFootstepDecalMaterialsMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
