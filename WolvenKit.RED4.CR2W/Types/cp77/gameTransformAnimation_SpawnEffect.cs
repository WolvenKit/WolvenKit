using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_SpawnEffect : gameTransformAnimation_Effects
	{
		private CName _effectName;
		private CName _effectTag;
		private CBool _persistOnDetach;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(1)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetProperty(ref _effectTag);
			set => SetProperty(ref _effectTag, value);
		}

		[Ordinal(2)] 
		[RED("persistOnDetach")] 
		public CBool PersistOnDetach
		{
			get => GetProperty(ref _persistOnDetach);
			set => SetProperty(ref _persistOnDetach, value);
		}

		public gameTransformAnimation_SpawnEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
