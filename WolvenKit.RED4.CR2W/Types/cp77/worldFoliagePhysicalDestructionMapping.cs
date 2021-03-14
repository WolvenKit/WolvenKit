using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePhysicalDestructionMapping : worldFoliageDestructionMapping
	{
		private CName _audioMetadata;
		private physicsDestructionParams _destructionParams;
		private CArray<physicsDestructionLevelData> _destructionLevelData;

		[Ordinal(3)] 
		[RED("audioMetadata")] 
		public CName AudioMetadata
		{
			get
			{
				if (_audioMetadata == null)
				{
					_audioMetadata = (CName) CR2WTypeManager.Create("CName", "audioMetadata", cr2w, this);
				}
				return _audioMetadata;
			}
			set
			{
				if (_audioMetadata == value)
				{
					return;
				}
				_audioMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("destructionParams")] 
		public physicsDestructionParams DestructionParams
		{
			get
			{
				if (_destructionParams == null)
				{
					_destructionParams = (physicsDestructionParams) CR2WTypeManager.Create("physicsDestructionParams", "destructionParams", cr2w, this);
				}
				return _destructionParams;
			}
			set
			{
				if (_destructionParams == value)
				{
					return;
				}
				_destructionParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("destructionLevelData")] 
		public CArray<physicsDestructionLevelData> DestructionLevelData
		{
			get
			{
				if (_destructionLevelData == null)
				{
					_destructionLevelData = (CArray<physicsDestructionLevelData>) CR2WTypeManager.Create("array:physicsDestructionLevelData", "destructionLevelData", cr2w, this);
				}
				return _destructionLevelData;
			}
			set
			{
				if (_destructionLevelData == value)
				{
					return;
				}
				_destructionLevelData = value;
				PropertySet(this);
			}
		}

		public worldFoliagePhysicalDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
