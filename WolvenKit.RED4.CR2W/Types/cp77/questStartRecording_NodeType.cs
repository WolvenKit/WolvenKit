using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStartRecording_NodeType : questIRecordingNodeType
	{
		private CBool _enabled;
		private CString _sectionName;

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
		[RED("sectionName")] 
		public CString SectionName
		{
			get
			{
				if (_sectionName == null)
				{
					_sectionName = (CString) CR2WTypeManager.Create("String", "sectionName", cr2w, this);
				}
				return _sectionName;
			}
			set
			{
				if (_sectionName == value)
				{
					return;
				}
				_sectionName = value;
				PropertySet(this);
			}
		}

		public questStartRecording_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
