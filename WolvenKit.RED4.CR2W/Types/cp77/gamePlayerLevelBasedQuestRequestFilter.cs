using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayerLevelBasedQuestRequestFilter : gameCustomRequestFilter
	{
		private CUInt32 _percentMargin;

		[Ordinal(0)] 
		[RED("percentMargin")] 
		public CUInt32 PercentMargin
		{
			get
			{
				if (_percentMargin == null)
				{
					_percentMargin = (CUInt32) CR2WTypeManager.Create("Uint32", "percentMargin", cr2w, this);
				}
				return _percentMargin;
			}
			set
			{
				if (_percentMargin == value)
				{
					return;
				}
				_percentMargin = value;
				PropertySet(this);
			}
		}

		public gamePlayerLevelBasedQuestRequestFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
