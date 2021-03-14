using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioAttractAreaSounds : audioAudioMetadata
	{
		private CArray<audioDynamicEventsPerVisualTags> _nPCgrunts;
		private CArray<audioDynamicEventsWithInterval> _environmentSounds;

		[Ordinal(1)] 
		[RED("NPCgrunts")] 
		public CArray<audioDynamicEventsPerVisualTags> NPCgrunts
		{
			get
			{
				if (_nPCgrunts == null)
				{
					_nPCgrunts = (CArray<audioDynamicEventsPerVisualTags>) CR2WTypeManager.Create("array:audioDynamicEventsPerVisualTags", "NPCgrunts", cr2w, this);
				}
				return _nPCgrunts;
			}
			set
			{
				if (_nPCgrunts == value)
				{
					return;
				}
				_nPCgrunts = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("environmentSounds")] 
		public CArray<audioDynamicEventsWithInterval> EnvironmentSounds
		{
			get
			{
				if (_environmentSounds == null)
				{
					_environmentSounds = (CArray<audioDynamicEventsWithInterval>) CR2WTypeManager.Create("array:audioDynamicEventsWithInterval", "environmentSounds", cr2w, this);
				}
				return _environmentSounds;
			}
			set
			{
				if (_environmentSounds == value)
				{
					return;
				}
				_environmentSounds = value;
				PropertySet(this);
			}
		}

		public audioAudioAttractAreaSounds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
