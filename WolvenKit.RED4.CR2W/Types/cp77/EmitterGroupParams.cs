using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupParams : CVariable
	{
		private CEnum<EEmitterGroup> _group;
		private CFloat _emissionScale;
		private CFloat _opacityScale;

		[Ordinal(0)] 
		[RED("group")] 
		public CEnum<EEmitterGroup> Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(1)] 
		[RED("emissionScale")] 
		public CFloat EmissionScale
		{
			get => GetProperty(ref _emissionScale);
			set => SetProperty(ref _emissionScale, value);
		}

		[Ordinal(2)] 
		[RED("opacityScale")] 
		public CFloat OpacityScale
		{
			get => GetProperty(ref _opacityScale);
			set => SetProperty(ref _opacityScale, value);
		}

		public EmitterGroupParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
