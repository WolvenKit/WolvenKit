using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageBakedDestructionMapping : worldFoliageDestructionMapping
	{
		private CFloat _numFrames;
		private CFloat _frameRate;
		private CName _audioMetadata;
		private raRef<worldEffect> _destructionEffect;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(3)] 
		[RED("numFrames")] 
		public CFloat NumFrames
		{
			get
			{
				if (_numFrames == null)
				{
					_numFrames = (CFloat) CR2WTypeManager.Create("Float", "numFrames", cr2w, this);
				}
				return _numFrames;
			}
			set
			{
				if (_numFrames == value)
				{
					return;
				}
				_numFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("frameRate")] 
		public CFloat FrameRate
		{
			get
			{
				if (_frameRate == null)
				{
					_frameRate = (CFloat) CR2WTypeManager.Create("Float", "frameRate", cr2w, this);
				}
				return _frameRate;
			}
			set
			{
				if (_frameRate == value)
				{
					return;
				}
				_frameRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("destructionEffect")] 
		public raRef<worldEffect> DestructionEffect
		{
			get
			{
				if (_destructionEffect == null)
				{
					_destructionEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "destructionEffect", cr2w, this);
				}
				return _destructionEffect;
			}
			set
			{
				if (_destructionEffect == value)
				{
					return;
				}
				_destructionEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get
			{
				if (_filterDataSource == null)
				{
					_filterDataSource = (CEnum<physicsFilterDataSource>) CR2WTypeManager.Create("physicsFilterDataSource", "filterDataSource", cr2w, this);
				}
				return _filterDataSource;
			}
			set
			{
				if (_filterDataSource == value)
				{
					return;
				}
				_filterDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		public worldFoliageBakedDestructionMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
