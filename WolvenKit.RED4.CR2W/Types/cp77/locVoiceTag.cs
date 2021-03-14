using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class locVoiceTag : CVariable
	{
		private CName _voiceTag;
		private CString _voicesetScenePath;
		private CRUID _id;
		private CBool _isApuc;

		[Ordinal(0)] 
		[RED("voiceTag")] 
		public CName VoiceTag
		{
			get
			{
				if (_voiceTag == null)
				{
					_voiceTag = (CName) CR2WTypeManager.Create("CName", "voiceTag", cr2w, this);
				}
				return _voiceTag;
			}
			set
			{
				if (_voiceTag == value)
				{
					return;
				}
				_voiceTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voicesetScenePath")] 
		public CString VoicesetScenePath
		{
			get
			{
				if (_voicesetScenePath == null)
				{
					_voicesetScenePath = (CString) CR2WTypeManager.Create("String", "voicesetScenePath", cr2w, this);
				}
				return _voicesetScenePath;
			}
			set
			{
				if (_voicesetScenePath == value)
				{
					return;
				}
				_voicesetScenePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("id")] 
		public CRUID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CRUID) CR2WTypeManager.Create("CRUID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isApuc")] 
		public CBool IsApuc
		{
			get
			{
				if (_isApuc == null)
				{
					_isApuc = (CBool) CR2WTypeManager.Create("Bool", "isApuc", cr2w, this);
				}
				return _isApuc;
			}
			set
			{
				if (_isApuc == value)
				{
					return;
				}
				_isApuc = value;
				PropertySet(this);
			}
		}

		public locVoiceTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
