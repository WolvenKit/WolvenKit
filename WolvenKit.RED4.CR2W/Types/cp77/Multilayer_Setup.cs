using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Setup : CResource
	{
		private CArray<Multilayer_Layer> _layers;
		private CFloat _ratio;
		private CBool _useNormal;

		[Ordinal(1)] 
		[RED("layers")] 
		public CArray<Multilayer_Layer> Layers
		{
			get => GetProperty(ref _layers);
			set => SetProperty(ref _layers, value);
		}

		[Ordinal(2)] 
		[RED("ratio")] 
		public CFloat Ratio
		{
			get => GetProperty(ref _ratio);
			set => SetProperty(ref _ratio, value);
		}

		[Ordinal(3)] 
		[RED("useNormal")] 
		public CBool UseNormal
		{
			get => GetProperty(ref _useNormal);
			set => SetProperty(ref _useNormal, value);
		}

		public Multilayer_Setup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
