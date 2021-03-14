using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnscreenVOPlayerController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _subtitlesContainer;
		private raRef<inkWidgetLibraryResource> _subtitlesLibraryResource;
		private CName _subtitlesRootName;
		private CArray<gameuiVOWithDelay> _audioVOList;

		[Ordinal(2)] 
		[RED("subtitlesContainer")] 
		public inkCompoundWidgetReference SubtitlesContainer
		{
			get
			{
				if (_subtitlesContainer == null)
				{
					_subtitlesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "subtitlesContainer", cr2w, this);
				}
				return _subtitlesContainer;
			}
			set
			{
				if (_subtitlesContainer == value)
				{
					return;
				}
				_subtitlesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("subtitlesLibraryResource")] 
		public raRef<inkWidgetLibraryResource> SubtitlesLibraryResource
		{
			get
			{
				if (_subtitlesLibraryResource == null)
				{
					_subtitlesLibraryResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "subtitlesLibraryResource", cr2w, this);
				}
				return _subtitlesLibraryResource;
			}
			set
			{
				if (_subtitlesLibraryResource == value)
				{
					return;
				}
				_subtitlesLibraryResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("subtitlesRootName")] 
		public CName SubtitlesRootName
		{
			get
			{
				if (_subtitlesRootName == null)
				{
					_subtitlesRootName = (CName) CR2WTypeManager.Create("CName", "subtitlesRootName", cr2w, this);
				}
				return _subtitlesRootName;
			}
			set
			{
				if (_subtitlesRootName == value)
				{
					return;
				}
				_subtitlesRootName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("audioVOList")] 
		public CArray<gameuiVOWithDelay> AudioVOList
		{
			get
			{
				if (_audioVOList == null)
				{
					_audioVOList = (CArray<gameuiVOWithDelay>) CR2WTypeManager.Create("array:gameuiVOWithDelay", "audioVOList", cr2w, this);
				}
				return _audioVOList;
			}
			set
			{
				if (_audioVOList == value)
				{
					return;
				}
				_audioVOList = value;
				PropertySet(this);
			}
		}

		public gameuiOnscreenVOPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
