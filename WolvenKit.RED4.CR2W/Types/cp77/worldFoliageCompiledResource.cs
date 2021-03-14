using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageCompiledResource : CResource
	{
		private CUInt32 _version;
		private CUInt32 _populationCount;
		private CUInt32 _bucketCount;
		private DataBuffer _dataBuffer;

		[Ordinal(1)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("populationCount")] 
		public CUInt32 PopulationCount
		{
			get
			{
				if (_populationCount == null)
				{
					_populationCount = (CUInt32) CR2WTypeManager.Create("Uint32", "populationCount", cr2w, this);
				}
				return _populationCount;
			}
			set
			{
				if (_populationCount == value)
				{
					return;
				}
				_populationCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bucketCount")] 
		public CUInt32 BucketCount
		{
			get
			{
				if (_bucketCount == null)
				{
					_bucketCount = (CUInt32) CR2WTypeManager.Create("Uint32", "bucketCount", cr2w, this);
				}
				return _bucketCount;
			}
			set
			{
				if (_bucketCount == value)
				{
					return;
				}
				_bucketCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("dataBuffer")] 
		public DataBuffer DataBuffer
		{
			get
			{
				if (_dataBuffer == null)
				{
					_dataBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "dataBuffer", cr2w, this);
				}
				return _dataBuffer;
			}
			set
			{
				if (_dataBuffer == value)
				{
					return;
				}
				_dataBuffer = value;
				PropertySet(this);
			}
		}

		public worldFoliageCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
