using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDesiredSlotsCountInfo : CVariable
	{
		private CFloat _siredSlotsCount;
		private CFloat _nCoeff;

		[Ordinal(0)] 
		[RED("siredSlotsCount")] 
		public CFloat SiredSlotsCount
		{
			get
			{
				if (_siredSlotsCount == null)
				{
					_siredSlotsCount = (CFloat) CR2WTypeManager.Create("Float", "siredSlotsCount", cr2w, this);
				}
				return _siredSlotsCount;
			}
			set
			{
				if (_siredSlotsCount == value)
				{
					return;
				}
				_siredSlotsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nCoeff")] 
		public CFloat NCoeff
		{
			get
			{
				if (_nCoeff == null)
				{
					_nCoeff = (CFloat) CR2WTypeManager.Create("Float", "nCoeff", cr2w, this);
				}
				return _nCoeff;
			}
			set
			{
				if (_nCoeff == value)
				{
					return;
				}
				_nCoeff = value;
				PropertySet(this);
			}
		}

		public worldDesiredSlotsCountInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
