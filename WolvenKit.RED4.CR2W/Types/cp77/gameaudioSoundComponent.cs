using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioSoundComponent : gameaudioSoundComponentBase
	{
		private CArray<gameaudioSoundComponentSubSystemWrapper> _subSystems;
		private CName _voEventOverride;
		private CFloat _minVocalizationRepeatTime;
		private CFloat _streamingDistance;

		[Ordinal(11)] 
		[RED("subSystems")] 
		public CArray<gameaudioSoundComponentSubSystemWrapper> SubSystems
		{
			get
			{
				if (_subSystems == null)
				{
					_subSystems = (CArray<gameaudioSoundComponentSubSystemWrapper>) CR2WTypeManager.Create("array:gameaudioSoundComponentSubSystemWrapper", "subSystems", cr2w, this);
				}
				return _subSystems;
			}
			set
			{
				if (_subSystems == value)
				{
					return;
				}
				_subSystems = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("voEventOverride")] 
		public CName VoEventOverride
		{
			get
			{
				if (_voEventOverride == null)
				{
					_voEventOverride = (CName) CR2WTypeManager.Create("CName", "voEventOverride", cr2w, this);
				}
				return _voEventOverride;
			}
			set
			{
				if (_voEventOverride == value)
				{
					return;
				}
				_voEventOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("minVocalizationRepeatTime")] 
		public CFloat MinVocalizationRepeatTime
		{
			get
			{
				if (_minVocalizationRepeatTime == null)
				{
					_minVocalizationRepeatTime = (CFloat) CR2WTypeManager.Create("Float", "minVocalizationRepeatTime", cr2w, this);
				}
				return _minVocalizationRepeatTime;
			}
			set
			{
				if (_minVocalizationRepeatTime == value)
				{
					return;
				}
				_minVocalizationRepeatTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get
			{
				if (_streamingDistance == null)
				{
					_streamingDistance = (CFloat) CR2WTypeManager.Create("Float", "streamingDistance", cr2w, this);
				}
				return _streamingDistance;
			}
			set
			{
				if (_streamingDistance == value)
				{
					return;
				}
				_streamingDistance = value;
				PropertySet(this);
			}
		}

		public gameaudioSoundComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
