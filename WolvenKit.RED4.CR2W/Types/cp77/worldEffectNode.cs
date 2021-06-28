using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEffectNode : worldNode
	{
		private raRef<worldEffect> _effect;
		private CFloat _streamingDistanceOverride;

		[Ordinal(4)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(5)] 
		[RED("streamingDistanceOverride")] 
		public CFloat StreamingDistanceOverride
		{
			get => GetProperty(ref _streamingDistanceOverride);
			set => SetProperty(ref _streamingDistanceOverride, value);
		}

		public worldEffectNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
