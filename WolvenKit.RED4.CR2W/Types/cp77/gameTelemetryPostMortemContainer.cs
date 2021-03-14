using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryPostMortemContainer : ISerializable
	{
		private gameTelemetryPostMortem _postMortem;

		[Ordinal(0)] 
		[RED("postMortem")] 
		public gameTelemetryPostMortem PostMortem
		{
			get
			{
				if (_postMortem == null)
				{
					_postMortem = (gameTelemetryPostMortem) CR2WTypeManager.Create("gameTelemetryPostMortem", "postMortem", cr2w, this);
				}
				return _postMortem;
			}
			set
			{
				if (_postMortem == value)
				{
					return;
				}
				_postMortem = value;
				PropertySet(this);
			}
		}

		public gameTelemetryPostMortemContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
