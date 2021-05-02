using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_Beam_RicochetPreview : gameEffectPostAction
	{
		private gameEffectPostAction_Beam_RicochetPreviewPreviewEffect _ricocheted;
		private gameEffectPostAction_Beam_RicochetPreviewPreviewEffect _fromMuzzle;

		[Ordinal(0)] 
		[RED("ricocheted")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect Ricocheted
		{
			get => GetProperty(ref _ricocheted);
			set => SetProperty(ref _ricocheted, value);
		}

		[Ordinal(1)] 
		[RED("fromMuzzle")] 
		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect FromMuzzle
		{
			get => GetProperty(ref _fromMuzzle);
			set => SetProperty(ref _fromMuzzle, value);
		}

		public gameEffectPostAction_Beam_RicochetPreview(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
