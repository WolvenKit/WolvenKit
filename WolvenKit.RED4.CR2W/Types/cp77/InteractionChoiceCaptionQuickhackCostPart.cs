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
			get
			{
				if (_cost == null)
				{
					_cost = (CInt32) CR2WTypeManager.Create("Int32", "cost", cr2w, this);
				}
				return _cost;
			}
			set
			{
				if (_cost == value)
				{
					return;
				}
				_cost = value;
				PropertySet(this);
			}
		}

		public InteractionChoiceCaptionQuickhackCostPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
