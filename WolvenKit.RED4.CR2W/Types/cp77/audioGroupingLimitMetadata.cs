using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGroupingLimitMetadata : audioAudioMetadata
	{
		private CFloat _limit;

		[Ordinal(1)] 
		[RED("limit")] 
		public CFloat Limit
		{
			get
			{
				if (_limit == null)
				{
					_limit = (CFloat) CR2WTypeManager.Create("Float", "limit", cr2w, this);
				}
				return _limit;
			}
			set
			{
				if (_limit == value)
				{
					return;
				}
				_limit = value;
				PropertySet(this);
			}
		}

		public audioGroupingLimitMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
