using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAdditionalSpeakers : CVariable
	{
		private CUInt8 _executionTag;
		private CEnum<scnAdditionalSpeakerRole> _role;
		private CArray<scnAdditionalSpeaker> _speakers;

		[Ordinal(0)] 
		[RED("executionTag")] 
		public CUInt8 ExecutionTag
		{
			get
			{
				if (_executionTag == null)
				{
					_executionTag = (CUInt8) CR2WTypeManager.Create("Uint8", "executionTag", cr2w, this);
				}
				return _executionTag;
			}
			set
			{
				if (_executionTag == value)
				{
					return;
				}
				_executionTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("role")] 
		public CEnum<scnAdditionalSpeakerRole> Role
		{
			get
			{
				if (_role == null)
				{
					_role = (CEnum<scnAdditionalSpeakerRole>) CR2WTypeManager.Create("scnAdditionalSpeakerRole", "role", cr2w, this);
				}
				return _role;
			}
			set
			{
				if (_role == value)
				{
					return;
				}
				_role = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speakers")] 
		public CArray<scnAdditionalSpeaker> Speakers
		{
			get
			{
				if (_speakers == null)
				{
					_speakers = (CArray<scnAdditionalSpeaker>) CR2WTypeManager.Create("array:scnAdditionalSpeaker", "speakers", cr2w, this);
				}
				return _speakers;
			}
			set
			{
				if (_speakers == value)
				{
					return;
				}
				_speakers = value;
				PropertySet(this);
			}
		}

		public scnAdditionalSpeakers(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
