using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayAnimEventExData : CVariable
	{
		private scneventsPlayAnimEventData _basic;
		private CFloat _weight;
		private CName _bodyPartMask;

		[Ordinal(0)] 
		[RED("basic")] 
		public scneventsPlayAnimEventData Basic
		{
			get
			{
				if (_basic == null)
				{
					_basic = (scneventsPlayAnimEventData) CR2WTypeManager.Create("scneventsPlayAnimEventData", "basic", cr2w, this);
				}
				return _basic;
			}
			set
			{
				if (_basic == value)
				{
					return;
				}
				_basic = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bodyPartMask")] 
		public CName BodyPartMask
		{
			get
			{
				if (_bodyPartMask == null)
				{
					_bodyPartMask = (CName) CR2WTypeManager.Create("CName", "bodyPartMask", cr2w, this);
				}
				return _bodyPartMask;
			}
			set
			{
				if (_bodyPartMask == value)
				{
					return;
				}
				_bodyPartMask = value;
				PropertySet(this);
			}
		}

		public scneventsPlayAnimEventExData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
