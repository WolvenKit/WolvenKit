using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SVfxInstanceData : CVariable
	{
		private CHandle<gameFxInstance> _fx;
		private CName _id;

		[Ordinal(0)] 
		[RED("fx")] 
		public CHandle<gameFxInstance> Fx
		{
			get => GetProperty(ref _fx);
			set => SetProperty(ref _fx, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CName Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public SVfxInstanceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
