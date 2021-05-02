using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameEffectTargetVisualizationData : IScriptable
	{
		private CName _bucketName;
		private CArray<entEntityID> _forceHighlightTargets;

		[Ordinal(0)] 
		[RED("bucketName")] 
		public CName BucketName
		{
			get => GetProperty(ref _bucketName);
			set => SetProperty(ref _bucketName, value);
		}

		[Ordinal(1)] 
		[RED("forceHighlightTargets")] 
		public CArray<entEntityID> ForceHighlightTargets
		{
			get => GetProperty(ref _forceHighlightTargets);
			set => SetProperty(ref _forceHighlightTargets, value);
		}

		public GameEffectTargetVisualizationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
