using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineData : CVariable
	{
		private CEnum<EOutlineType> _outlineType;
		private CFloat _outlineStrength;

		[Ordinal(0)] 
		[RED("outlineType")] 
		public CEnum<EOutlineType> OutlineType
		{
			get
			{
				if (_outlineType == null)
				{
					_outlineType = (CEnum<EOutlineType>) CR2WTypeManager.Create("EOutlineType", "outlineType", cr2w, this);
				}
				return _outlineType;
			}
			set
			{
				if (_outlineType == value)
				{
					return;
				}
				_outlineType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outlineStrength")] 
		public CFloat OutlineStrength
		{
			get
			{
				if (_outlineStrength == null)
				{
					_outlineStrength = (CFloat) CR2WTypeManager.Create("Float", "outlineStrength", cr2w, this);
				}
				return _outlineStrength;
			}
			set
			{
				if (_outlineStrength == value)
				{
					return;
				}
				_outlineStrength = value;
				PropertySet(this);
			}
		}

		public OutlineData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
