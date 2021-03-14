using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetVideo : gameJournalInternetBase
	{
		private raRef<Bink> _videoResource;

		[Ordinal(4)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get
			{
				if (_videoResource == null)
				{
					_videoResource = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "videoResource", cr2w, this);
				}
				return _videoResource;
			}
			set
			{
				if (_videoResource == value)
				{
					return;
				}
				_videoResource = value;
				PropertySet(this);
			}
		}

		public gameJournalInternetVideo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
