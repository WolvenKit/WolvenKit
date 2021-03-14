using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioEntityMetadata : audioAudioMetadata
	{
		private CArray<CName> _fallbackDecorators;
		private CName _defaultPositionName;
		private CName _defaultEmitterName;
		private CName _isDefaultForEntityType;
		private CBool _preferSoundComponentPosition;
		private CInt32 _priority;
		private CName _rigMetadata;
		private CArray<audioEntityEmitterSettings> _emitterDescriptions;
		private CBool _alwaysCreateDefaultEmitter;

		[Ordinal(1)] 
		[RED("fallbackDecorators")] 
		public CArray<CName> FallbackDecorators
		{
			get
			{
				if (_fallbackDecorators == null)
				{
					_fallbackDecorators = (CArray<CName>) CR2WTypeManager.Create("array:CName", "fallbackDecorators", cr2w, this);
				}
				return _fallbackDecorators;
			}
			set
			{
				if (_fallbackDecorators == value)
				{
					return;
				}
				_fallbackDecorators = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultPositionName")] 
		public CName DefaultPositionName
		{
			get
			{
				if (_defaultPositionName == null)
				{
					_defaultPositionName = (CName) CR2WTypeManager.Create("CName", "defaultPositionName", cr2w, this);
				}
				return _defaultPositionName;
			}
			set
			{
				if (_defaultPositionName == value)
				{
					return;
				}
				_defaultPositionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultEmitterName")] 
		public CName DefaultEmitterName
		{
			get
			{
				if (_defaultEmitterName == null)
				{
					_defaultEmitterName = (CName) CR2WTypeManager.Create("CName", "defaultEmitterName", cr2w, this);
				}
				return _defaultEmitterName;
			}
			set
			{
				if (_defaultEmitterName == value)
				{
					return;
				}
				_defaultEmitterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isDefaultForEntityType")] 
		public CName IsDefaultForEntityType
		{
			get
			{
				if (_isDefaultForEntityType == null)
				{
					_isDefaultForEntityType = (CName) CR2WTypeManager.Create("CName", "isDefaultForEntityType", cr2w, this);
				}
				return _isDefaultForEntityType;
			}
			set
			{
				if (_isDefaultForEntityType == value)
				{
					return;
				}
				_isDefaultForEntityType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("preferSoundComponentPosition")] 
		public CBool PreferSoundComponentPosition
		{
			get
			{
				if (_preferSoundComponentPosition == null)
				{
					_preferSoundComponentPosition = (CBool) CR2WTypeManager.Create("Bool", "preferSoundComponentPosition", cr2w, this);
				}
				return _preferSoundComponentPosition;
			}
			set
			{
				if (_preferSoundComponentPosition == value)
				{
					return;
				}
				_preferSoundComponentPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rigMetadata")] 
		public CName RigMetadata
		{
			get
			{
				if (_rigMetadata == null)
				{
					_rigMetadata = (CName) CR2WTypeManager.Create("CName", "rigMetadata", cr2w, this);
				}
				return _rigMetadata;
			}
			set
			{
				if (_rigMetadata == value)
				{
					return;
				}
				_rigMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("emitterDescriptions")] 
		public CArray<audioEntityEmitterSettings> EmitterDescriptions
		{
			get
			{
				if (_emitterDescriptions == null)
				{
					_emitterDescriptions = (CArray<audioEntityEmitterSettings>) CR2WTypeManager.Create("array:audioEntityEmitterSettings", "emitterDescriptions", cr2w, this);
				}
				return _emitterDescriptions;
			}
			set
			{
				if (_emitterDescriptions == value)
				{
					return;
				}
				_emitterDescriptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("alwaysCreateDefaultEmitter")] 
		public CBool AlwaysCreateDefaultEmitter
		{
			get
			{
				if (_alwaysCreateDefaultEmitter == null)
				{
					_alwaysCreateDefaultEmitter = (CBool) CR2WTypeManager.Create("Bool", "alwaysCreateDefaultEmitter", cr2w, this);
				}
				return _alwaysCreateDefaultEmitter;
			}
			set
			{
				if (_alwaysCreateDefaultEmitter == value)
				{
					return;
				}
				_alwaysCreateDefaultEmitter = value;
				PropertySet(this);
			}
		}

		public audioEntityMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
