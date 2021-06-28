using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEffectVisualisationRequest : redEvent
	{
		private CName _areaEffectID;
		private CBool _show;

		[Ordinal(0)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetProperty(ref _areaEffectID);
			set => SetProperty(ref _areaEffectID, value);
		}

		[Ordinal(1)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		public AreaEffectVisualisationRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
