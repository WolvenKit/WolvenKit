using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceSubtitleMapEntry : CVariable
	{
		private CName _subtitleGroup;
		private raRef<JsonResource> _subtitleFile;

		[Ordinal(0)] 
		[RED("subtitleGroup")] 
		public CName SubtitleGroup
		{
			get
			{
				if (_subtitleGroup == null)
				{
					_subtitleGroup = (CName) CR2WTypeManager.Create("CName", "subtitleGroup", cr2w, this);
				}
				return _subtitleGroup;
			}
			set
			{
				if (_subtitleGroup == value)
				{
					return;
				}
				_subtitleGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("subtitleFile")] 
		public raRef<JsonResource> SubtitleFile
		{
			get
			{
				if (_subtitleFile == null)
				{
					_subtitleFile = (raRef<JsonResource>) CR2WTypeManager.Create("raRef:JsonResource", "subtitleFile", cr2w, this);
				}
				return _subtitleFile;
			}
			set
			{
				if (_subtitleFile == value)
				{
					return;
				}
				_subtitleFile = value;
				PropertySet(this);
			}
		}

		public localizationPersistenceSubtitleMapEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
