using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAudioEmitterComponent : entIPlacedComponent
	{
		private CName _emitterName;
		private CEnum<audioEntityEmitterContextType> _emitterType;
		private gameAudioSyncs _onAttach;
		private gameAudioSyncs _onDetach;
		private CFloat _updateDistance;
		private CName _emitterMetadataName;
		private CArray<CName> _tags;
		private redTagList _tagList;

		[Ordinal(5)] 
		[RED("EmitterName")] 
		public CName EmitterName
		{
			get
			{
				if (_emitterName == null)
				{
					_emitterName = (CName) CR2WTypeManager.Create("CName", "EmitterName", cr2w, this);
				}
				return _emitterName;
			}
			set
			{
				if (_emitterName == value)
				{
					return;
				}
				_emitterName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("EmitterType")] 
		public CEnum<audioEntityEmitterContextType> EmitterType
		{
			get
			{
				if (_emitterType == null)
				{
					_emitterType = (CEnum<audioEntityEmitterContextType>) CR2WTypeManager.Create("audioEntityEmitterContextType", "EmitterType", cr2w, this);
				}
				return _emitterType;
			}
			set
			{
				if (_emitterType == value)
				{
					return;
				}
				_emitterType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("OnAttach")] 
		public gameAudioSyncs OnAttach
		{
			get
			{
				if (_onAttach == null)
				{
					_onAttach = (gameAudioSyncs) CR2WTypeManager.Create("gameAudioSyncs", "OnAttach", cr2w, this);
				}
				return _onAttach;
			}
			set
			{
				if (_onAttach == value)
				{
					return;
				}
				_onAttach = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("OnDetach")] 
		public gameAudioSyncs OnDetach
		{
			get
			{
				if (_onDetach == null)
				{
					_onDetach = (gameAudioSyncs) CR2WTypeManager.Create("gameAudioSyncs", "OnDetach", cr2w, this);
				}
				return _onDetach;
			}
			set
			{
				if (_onDetach == value)
				{
					return;
				}
				_onDetach = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("updateDistance")] 
		public CFloat UpdateDistance
		{
			get
			{
				if (_updateDistance == null)
				{
					_updateDistance = (CFloat) CR2WTypeManager.Create("Float", "updateDistance", cr2w, this);
				}
				return _updateDistance;
			}
			set
			{
				if (_updateDistance == value)
				{
					return;
				}
				_updateDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get
			{
				if (_emitterMetadataName == null)
				{
					_emitterMetadataName = (CName) CR2WTypeManager.Create("CName", "emitterMetadataName", cr2w, this);
				}
				return _emitterMetadataName;
			}
			set
			{
				if (_emitterMetadataName == value)
				{
					return;
				}
				_emitterMetadataName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "Tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("TagList")] 
		public redTagList TagList
		{
			get
			{
				if (_tagList == null)
				{
					_tagList = (redTagList) CR2WTypeManager.Create("redTagList", "TagList", cr2w, this);
				}
				return _tagList;
			}
			set
			{
				if (_tagList == value)
				{
					return;
				}
				_tagList = value;
				PropertySet(this);
			}
		}

		public gameAudioEmitterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
