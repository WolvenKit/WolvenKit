using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliagePopulationSpanInfo : CVariable
	{
		private CUInt32 _stancesBegin;
		private CUInt32 _cketBegin;
		private CUInt32 _stancesCount;
		private CUInt32 _cketCount;

		[Ordinal(0)] 
		[RED("stancesBegin")] 
		public CUInt32 StancesBegin
		{
			get
			{
				if (_stancesBegin == null)
				{
					_stancesBegin = (CUInt32) CR2WTypeManager.Create("Uint32", "stancesBegin", cr2w, this);
				}
				return _stancesBegin;
			}
			set
			{
				if (_stancesBegin == value)
				{
					return;
				}
				_stancesBegin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cketBegin")] 
		public CUInt32 CketBegin
		{
			get
			{
				if (_cketBegin == null)
				{
					_cketBegin = (CUInt32) CR2WTypeManager.Create("Uint32", "cketBegin", cr2w, this);
				}
				return _cketBegin;
			}
			set
			{
				if (_cketBegin == value)
				{
					return;
				}
				_cketBegin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stancesCount")] 
		public CUInt32 StancesCount
		{
			get
			{
				if (_stancesCount == null)
				{
					_stancesCount = (CUInt32) CR2WTypeManager.Create("Uint32", "stancesCount", cr2w, this);
				}
				return _stancesCount;
			}
			set
			{
				if (_stancesCount == value)
				{
					return;
				}
				_stancesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cketCount")] 
		public CUInt32 CketCount
		{
			get
			{
				if (_cketCount == null)
				{
					_cketCount = (CUInt32) CR2WTypeManager.Create("Uint32", "cketCount", cr2w, this);
				}
				return _cketCount;
			}
			set
			{
				if (_cketCount == value)
				{
					return;
				}
				_cketCount = value;
				PropertySet(this);
			}
		}

		public worldFoliagePopulationSpanInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
