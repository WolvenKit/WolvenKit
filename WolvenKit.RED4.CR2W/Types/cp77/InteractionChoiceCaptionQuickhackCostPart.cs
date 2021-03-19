using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionChoiceCaptionQuickhackCostPart : gameinteractionsChoiceCaptionScriptPart
	{
		private CInt32 _cost;

		[Ordinal(0)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetProperty(ref _cost);
			set => SetProperty(ref _cost, value);
		}

		public InteractionChoiceCaptionQuickhackCostPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
