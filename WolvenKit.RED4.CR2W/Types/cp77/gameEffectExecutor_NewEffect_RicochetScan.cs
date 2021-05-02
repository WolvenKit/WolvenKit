using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_NewEffect_RicochetScan : gameEffectExecutor_NewEffect
	{
		private Vector4 _box;
		private CBool _isPreview;

		[Ordinal(5)] 
		[RED("box")] 
		public Vector4 Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		[Ordinal(6)] 
		[RED("isPreview")] 
		public CBool IsPreview
		{
			get => GetProperty(ref _isPreview);
			set => SetProperty(ref _isPreview, value);
		}

		public gameEffectExecutor_NewEffect_RicochetScan(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
