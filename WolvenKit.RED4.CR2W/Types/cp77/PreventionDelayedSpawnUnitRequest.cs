using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionDelayedSpawnUnitRequest : gameScriptableSystemRequest
	{
		private TweakDBID _recordID;
		private CUInt32 _preventionLevel;
		private WorldTransform _spawnTransform;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("preventionLevel")] 
		public CUInt32 PreventionLevel
		{
			get
			{
				if (_preventionLevel == null)
				{
					_preventionLevel = (CUInt32) CR2WTypeManager.Create("Uint32", "preventionLevel", cr2w, this);
				}
				return _preventionLevel;
			}
			set
			{
				if (_preventionLevel == value)
				{
					return;
				}
				_preventionLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawnTransform")] 
		public WorldTransform SpawnTransform
		{
			get
			{
				if (_spawnTransform == null)
				{
					_spawnTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "spawnTransform", cr2w, this);
				}
				return _spawnTransform;
			}
			set
			{
				if (_spawnTransform == value)
				{
					return;
				}
				_spawnTransform = value;
				PropertySet(this);
			}
		}

		public PreventionDelayedSpawnUnitRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
