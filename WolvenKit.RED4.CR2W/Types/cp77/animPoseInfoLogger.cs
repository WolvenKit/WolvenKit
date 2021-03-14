using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLogger : CVariable
	{
		private CBool _enabled;
		private CBool _showStackTransformsCount;
		private CBool _showStackTracksCount;
		private CArray<CHandle<animPoseInfoLoggerEntry>> _entries;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("showStackTransformsCount")] 
		public CBool ShowStackTransformsCount
		{
			get
			{
				if (_showStackTransformsCount == null)
				{
					_showStackTransformsCount = (CBool) CR2WTypeManager.Create("Bool", "showStackTransformsCount", cr2w, this);
				}
				return _showStackTransformsCount;
			}
			set
			{
				if (_showStackTransformsCount == value)
				{
					return;
				}
				_showStackTransformsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("showStackTracksCount")] 
		public CBool ShowStackTracksCount
		{
			get
			{
				if (_showStackTracksCount == null)
				{
					_showStackTracksCount = (CBool) CR2WTypeManager.Create("Bool", "showStackTracksCount", cr2w, this);
				}
				return _showStackTracksCount;
			}
			set
			{
				if (_showStackTracksCount == value)
				{
					return;
				}
				_showStackTracksCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entries")] 
		public CArray<CHandle<animPoseInfoLoggerEntry>> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<CHandle<animPoseInfoLoggerEntry>>) CR2WTypeManager.Create("array:handle:animPoseInfoLoggerEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public animPoseInfoLogger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
