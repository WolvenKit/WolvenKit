using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChatter : CVariable
	{
		private CUInt16 _id;
		private wCHandle<scnVoicesetComponent> _voicesetComponent;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt16) CR2WTypeManager.Create("Uint16", "id", cr2w, this);
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

		[Ordinal(1)] 
		[RED("voicesetComponent")] 
		public wCHandle<scnVoicesetComponent> VoicesetComponent
		{
			get
			{
				if (_voicesetComponent == null)
				{
					_voicesetComponent = (wCHandle<scnVoicesetComponent>) CR2WTypeManager.Create("whandle:scnVoicesetComponent", "voicesetComponent", cr2w, this);
				}
				return _voicesetComponent;
			}
			set
			{
				if (_voicesetComponent == value)
				{
					return;
				}
				_voicesetComponent = value;
				PropertySet(this);
			}
		}

		public scnChatter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
