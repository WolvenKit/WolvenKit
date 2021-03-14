using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TimingsDetailed : CVariable
	{
		private CName _className;
		private CFloat _avarageExclusiveUpdateTimeMS;
		private CFloat _avarageInclusiveUpdateTimeMS;
		private CFloat _avarageExclusiveSampleTimeMS;
		private CFloat _avarageInclusiveSampleTimeMS;
		private CFloat _totalExclusiveUpdateTimeMS;
		private CFloat _totalInclusiveUpdateTimeMS;
		private CFloat _totalExclusiveSampleTimeMS;
		private CFloat _totalInclusiveSampleTimeMS;
		private CUInt32 _updatesCount;
		private CUInt32 _samplesCount;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("avarageExclusiveUpdateTimeMS")] 
		public CFloat AvarageExclusiveUpdateTimeMS
		{
			get
			{
				if (_avarageExclusiveUpdateTimeMS == null)
				{
					_avarageExclusiveUpdateTimeMS = (CFloat) CR2WTypeManager.Create("Float", "avarageExclusiveUpdateTimeMS", cr2w, this);
				}
				return _avarageExclusiveUpdateTimeMS;
			}
			set
			{
				if (_avarageExclusiveUpdateTimeMS == value)
				{
					return;
				}
				_avarageExclusiveUpdateTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("avarageInclusiveUpdateTimeMS")] 
		public CFloat AvarageInclusiveUpdateTimeMS
		{
			get
			{
				if (_avarageInclusiveUpdateTimeMS == null)
				{
					_avarageInclusiveUpdateTimeMS = (CFloat) CR2WTypeManager.Create("Float", "avarageInclusiveUpdateTimeMS", cr2w, this);
				}
				return _avarageInclusiveUpdateTimeMS;
			}
			set
			{
				if (_avarageInclusiveUpdateTimeMS == value)
				{
					return;
				}
				_avarageInclusiveUpdateTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("avarageExclusiveSampleTimeMS")] 
		public CFloat AvarageExclusiveSampleTimeMS
		{
			get
			{
				if (_avarageExclusiveSampleTimeMS == null)
				{
					_avarageExclusiveSampleTimeMS = (CFloat) CR2WTypeManager.Create("Float", "avarageExclusiveSampleTimeMS", cr2w, this);
				}
				return _avarageExclusiveSampleTimeMS;
			}
			set
			{
				if (_avarageExclusiveSampleTimeMS == value)
				{
					return;
				}
				_avarageExclusiveSampleTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("avarageInclusiveSampleTimeMS")] 
		public CFloat AvarageInclusiveSampleTimeMS
		{
			get
			{
				if (_avarageInclusiveSampleTimeMS == null)
				{
					_avarageInclusiveSampleTimeMS = (CFloat) CR2WTypeManager.Create("Float", "avarageInclusiveSampleTimeMS", cr2w, this);
				}
				return _avarageInclusiveSampleTimeMS;
			}
			set
			{
				if (_avarageInclusiveSampleTimeMS == value)
				{
					return;
				}
				_avarageInclusiveSampleTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("totalExclusiveUpdateTimeMS")] 
		public CFloat TotalExclusiveUpdateTimeMS
		{
			get
			{
				if (_totalExclusiveUpdateTimeMS == null)
				{
					_totalExclusiveUpdateTimeMS = (CFloat) CR2WTypeManager.Create("Float", "totalExclusiveUpdateTimeMS", cr2w, this);
				}
				return _totalExclusiveUpdateTimeMS;
			}
			set
			{
				if (_totalExclusiveUpdateTimeMS == value)
				{
					return;
				}
				_totalExclusiveUpdateTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("totalInclusiveUpdateTimeMS")] 
		public CFloat TotalInclusiveUpdateTimeMS
		{
			get
			{
				if (_totalInclusiveUpdateTimeMS == null)
				{
					_totalInclusiveUpdateTimeMS = (CFloat) CR2WTypeManager.Create("Float", "totalInclusiveUpdateTimeMS", cr2w, this);
				}
				return _totalInclusiveUpdateTimeMS;
			}
			set
			{
				if (_totalInclusiveUpdateTimeMS == value)
				{
					return;
				}
				_totalInclusiveUpdateTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("totalExclusiveSampleTimeMS")] 
		public CFloat TotalExclusiveSampleTimeMS
		{
			get
			{
				if (_totalExclusiveSampleTimeMS == null)
				{
					_totalExclusiveSampleTimeMS = (CFloat) CR2WTypeManager.Create("Float", "totalExclusiveSampleTimeMS", cr2w, this);
				}
				return _totalExclusiveSampleTimeMS;
			}
			set
			{
				if (_totalExclusiveSampleTimeMS == value)
				{
					return;
				}
				_totalExclusiveSampleTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("totalInclusiveSampleTimeMS")] 
		public CFloat TotalInclusiveSampleTimeMS
		{
			get
			{
				if (_totalInclusiveSampleTimeMS == null)
				{
					_totalInclusiveSampleTimeMS = (CFloat) CR2WTypeManager.Create("Float", "totalInclusiveSampleTimeMS", cr2w, this);
				}
				return _totalInclusiveSampleTimeMS;
			}
			set
			{
				if (_totalInclusiveSampleTimeMS == value)
				{
					return;
				}
				_totalInclusiveSampleTimeMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("updatesCount")] 
		public CUInt32 UpdatesCount
		{
			get
			{
				if (_updatesCount == null)
				{
					_updatesCount = (CUInt32) CR2WTypeManager.Create("Uint32", "updatesCount", cr2w, this);
				}
				return _updatesCount;
			}
			set
			{
				if (_updatesCount == value)
				{
					return;
				}
				_updatesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("samplesCount")] 
		public CUInt32 SamplesCount
		{
			get
			{
				if (_samplesCount == null)
				{
					_samplesCount = (CUInt32) CR2WTypeManager.Create("Uint32", "samplesCount", cr2w, this);
				}
				return _samplesCount;
			}
			set
			{
				if (_samplesCount == value)
				{
					return;
				}
				_samplesCount = value;
				PropertySet(this);
			}
		}

		public animAnimProfilerData_TimingsDetailed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
