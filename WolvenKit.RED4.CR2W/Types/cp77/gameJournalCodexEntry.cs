using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexEntry : gameJournalContainerEntry
	{
		private LocalizationString _title;
		private TweakDBID _imageId;
		private TweakDBID _linkImageId;

		[Ordinal(2)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get
			{
				if (_imageId == null)
				{
					_imageId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "imageId", cr2w, this);
				}
				return _imageId;
			}
			set
			{
				if (_imageId == value)
				{
					return;
				}
				_imageId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("linkImageId")] 
		public TweakDBID LinkImageId
		{
			get
			{
				if (_linkImageId == null)
				{
					_linkImageId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "linkImageId", cr2w, this);
				}
				return _linkImageId;
			}
			set
			{
				if (_linkImageId == value)
				{
					return;
				}
				_linkImageId = value;
				PropertySet(this);
			}
		}

		public gameJournalCodexEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
